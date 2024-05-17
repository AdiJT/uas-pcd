﻿using OlahCitra.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PCD
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private FormOptions _formOptions = new FormOptions();
        private readonly double _skala = 0.01834;
        private List<Result> _daftarHasil = new List<Result>();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private async void FormMain_ShownAsync(object sender, EventArgs e)
        {
            await ProsesAsync();
        }

        private class Result
        {
            public string NamaFile { get; set; }
            public Bitmap Original { get; set; }
            public Bitmap Hasil { get; set; }
            public Dictionary<string, Bitmap> Step { get; set; }
        }

        private async Task ProsesAsync()
        {
            if (_formOptions.ShowDialog() == DialogResult.OK)
            {
                buttonUlang.Enabled = false;
                dataGridViewHasil.Enabled = false;

                var options = _formOptions.Options;
                options.DaftarWarnaBangunan = options.DaftarWarnaBangunan.Select(h => new HsvColorRange(
                    new int[] { h.Low[0] / 2, h.Low[1], h.Low[2] },
                    new int[] { h.High[0] / 2, h.High[1], h.High[2] })).ToList();


                progressBar1.Value = 0;
                var progress = new Progress<int>(
                    v =>
                progressBar1.Value += v
                );

                await Task.Run(() => DoWork(progress, options));

                RefreshDataGrid();

                buttonUlang.Enabled = true;
                dataGridViewHasil.Enabled = true;
                progressBar1.Value = 0;
            }
        }

        private void DoWork(IProgress<int> progress, Options options)
        {
            List<Result> results = new List<Result>();

            var ekstensi = new string[] { "*.jpg", "*.jpeg" };
            var files = ekstensi.AsParallel().SelectMany(e => Directory.EnumerateFiles(options.FolderPath, e)).ToList();
            foreach (var file in files)
            {
                var bitmap = new Bitmap(file);
                results.Add(new Result()
                {
                    NamaFile = file,
                    Original = bitmap,
                    Step = new Dictionary<string, Bitmap>() { { "Original", bitmap } }
                });
            }

            foreach (var result in results)
            {
                var colorCorrected = ImageProcessing.ColorCorrection(result.Original, 10, 10, 20);

                var segmentedImages = new List<Bitmap>();
                foreach (var color in options.DaftarWarnaBangunan)
                    segmentedImages.Add(ImageProcessing.HSVColorSegmentation(colorCorrected, color.Low, color.High));

                var otsus = segmentedImages.Select(i => ImageProcessing.OtsuCv(i)).ToList();
                var openings = otsus.Select(i => ImageProcessing.Opening(i, options.OpeningKernelSize)).ToList();
                var closings = openings.Select(i => ImageProcessing.Closing(i, options.ClosingKernelSize)).ToList();

                var combination = ImageProcessing.CombineWithOr(closings);

                (var blobImage, var blobs) = ImageProcessing.BlobDetection(combination, options.MinimalBlobSize);
                var hasil = ImageProcessing.HitungLuas(result.Original, blobs, _skala);

                result.Step.Add("Color Correction (R:10, G:10, B:20)", colorCorrected);
                result.Step.Add("HSV Color Segmentation", CombineImage(segmentedImages.ToList(), 4, result.Original.Size));
                result.Step.Add("Ostu Thresholding Segmentation", CombineImage(otsus, 4, result.Original.Size));
                result.Step.Add($"Opening {options.OpeningKernelSize} X {options.OpeningKernelSize}", CombineImage(openings, 4, result.Original.Size));
                result.Step.Add($"Closing {options.ClosingKernelSize} X {options.ClosingKernelSize}", CombineImage(closings, 4, result.Original.Size));
                result.Step.Add("Kombinasi", combination);
                result.Step.Add($"Blob Detection", blobImage);
                result.Step.Add($"Hasil", hasil);
                result.Hasil = hasil;

                progress.Report((int)(1d / results.Count * 100d));
            }

            _daftarHasil = results;

        }

        private void RefreshDataGrid()
        {

            dataGridViewHasil.Rows.Clear();
            for (int i = 0; i < _daftarHasil.Count; i++)
            {
                var result = _daftarHasil[i];
                dataGridViewHasil.Rows.Add();
                dataGridViewHasil.Rows[i].Cells[0].Value = i + 1;
                dataGridViewHasil.Rows[i].Cells[1].Value = result.NamaFile;
                dataGridViewHasil.Rows[i].Cells[2].Value = result.Original;
                dataGridViewHasil.Rows[i].Cells[3].Value = result.Hasil;

                var detailButton = new Button();
                dataGridViewHasil.Rows[i].Cells[4].Value = detailButton;
            }
        }

        private Bitmap CombineImage(List<Bitmap> images, int colSize, Size originalSize)
        {
            colSize = Math.Min(images.Count, colSize);
            int rows = Math.Max(images.Count / colSize, 1);

            int shift = 10;
            var outImage = new Bitmap(colSize * (originalSize.Width + shift), rows * (originalSize.Height + shift));

            using (var g = Graphics.FromImage(outImage))
            {
                var col = 0;
                var row = 0;
                foreach (var item in images)
                {
                    g.DrawImage(item, new Point(col * (originalSize.Width + shift), row * (originalSize.Height + shift)));
                    if (col == colSize - 1)
                    {
                        col = 0;
                        row++;
                    }
                    else
                        col++;
                }
            }

            return outImage;
        }

        private async void buttonUlang_Click(object sender, EventArgs e)
        {
            await ProsesAsync();
        }

        private void dataGridViewHasil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.RowIndex != _daftarHasil.Count)
            {
                var formDetail = new FormDetail();
                formDetail.SetImages(_daftarHasil[e.RowIndex].Step);
                formDetail.ShowDialog();
            }
        }
    }
}