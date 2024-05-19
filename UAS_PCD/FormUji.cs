using OlahCitra.Core;
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
    public partial class FormUji : Form
    {
        public FormUji()
        {
            InitializeComponent();
        }

        public List<(Bitmap original, Bitmap segmentasi)> Data { get; set; }

        private void buttonPilihFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBoxFolderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonUji_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFolderPath.Text))
            {
                List<Bitmap> dataReferensi = new List<Bitmap>();
                List<(double akurasi, double presisi, double recall)> hasilUji = new List<(double akurasi, double presisi, double recall)>();

                var ekstensi = new string[] { "*.jpg", "*.jpeg" };
                var files = ekstensi.AsParallel().SelectMany(f => Directory.EnumerateFiles(textBoxFolderPath.Text, f)).ToList();
                foreach (var file in files)
                {
                    var bitmap = new Bitmap(file);
                    dataReferensi.Add(bitmap);
                }

                for(int i = 0; i < dataReferensi.Count; i++)
                {
                    var referensi = ImageProcessing.OtsuCv(dataReferensi[i]);
                    var segmentasi = Data[i].segmentasi;

                    double p = 0;
                    double n = 0;
                    double tp = 0;
                    double tn = 0;
                    double fp = 0;
                    double fn = 0;

                    for(int x = 0; x < referensi.Width; x++)
                        for(int y = 0; y < referensi.Height; y++)
                        {
                            var pixelReferensi = referensi.GetPixel(x, y);
                            var pixelHasil = segmentasi.GetPixel(x, y);

                            if(pixelReferensi.R == 255 && pixelReferensi.G == 255 && pixelReferensi.G == 255)
                            {
                                p++;
                                if (pixelHasil.R == 255 && pixelHasil.G == 255 && pixelHasil.G == 255)
                                    tp++;
                                else
                                    fn++;
                            }
                            else
                            {
                                n++;
                                if (pixelHasil.R == 255 && pixelHasil.G == 255 && pixelHasil.G == 255)
                                    fp++;
                                else
                                    tn++;
                            }
                        }

                    var akurasi = (tp + tn) / (p + n);
                    var presisi = tp / (tp + fp);
                    var recall = tp / p;


                    dataReferensi[i] = referensi;
                    hasilUji.Add((akurasi, presisi, recall));
                }

                dataGridViewUji.Rows.Clear();
                for(int i = 0; i < hasilUji.Count; i++)
                {

                    var index = dataGridViewUji.Rows.Add();
                    dataGridViewUji.Rows[index].Cells[0].Value = i + 1;
                    dataGridViewUji.Rows[index].Cells[1].Value = dataReferensi[i];
                    dataGridViewUji.Rows[index].Cells[2].Value = $"{ hasilUji[i].akurasi:F4}";
                    dataGridViewUji.Rows[index].Cells[3].Value = $"{hasilUji[i].presisi:F4}";
                    dataGridViewUji.Rows[index].Cells[4].Value = $"{hasilUji[i].recall:F4}";
                }
            }
        }
    }
}
