using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PCD
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private readonly List<HsvColorRange> _listWarnaBangunan = new List<HsvColorRange>();

        public Options Options
        {
            get => new Options
            {
                FolderPath = textBoxFolderPath.Text,
                ClosingKernelSize = (int)numericUpDownClosing.Value,
                OpeningKernelSize = (int)numericUpDownOpening.Value,
                MinimalBlobSize = (int)numericUpDownMinJmlPiksel.Value,
                DaftarWarnaBangunan = _listWarnaBangunan
            };
        }

        private void RefreshDataGrid()
        {
            var dataSource = _listWarnaBangunan.Select((h, i) => new
            {
                No = i + 1,
                Low = $"H:{h.Low[0]} S:{h.Low[1]} V:{h.Low[2]}",
                High = $"H:{h.High[0]} S:{h.High[1]} V:{h.High[2]}",
            }).ToList();
            dataGridViewHsvColor.DataSource = dataSource;
        }

        private void buttonPilihFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                var folder = folderBrowserDialog1.SelectedPath;
                textBoxFolderPath.Text = folder;
                folderBrowserDialog1.Dispose();
            }
        }

        private void numericUpDownOpening_ValueChanged(object sender, EventArgs e)
        {
            labelOpening.Text = $"Besar Kernel Opening {numericUpDownOpening.Value} X {numericUpDownOpening.Value}";
        }

        private void numericUpDownClosing_ValueChanged(object sender, EventArgs e)
        {
            labelClosing.Text = $"Besar Kernel Closing {numericUpDownClosing.Value} X {numericUpDownClosing.Value}";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            using (var formTambah = new FormTambahWarna())
            {
                if(formTambah.ShowDialog() == DialogResult.OK)
                {
                    _listWarnaBangunan.Add(formTambah.Warna);
                    RefreshDataGrid();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var options = Options;

            if(string.IsNullOrEmpty(options.FolderPath))
            {
                MessageBox.Show("Pilh folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(options.DaftarWarnaBangunan.Count == 0)
            {
                MessageBox.Show("Pilh minimal 1 warna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (_listWarnaBangunan.Count > 0)
            {
                _listWarnaBangunan.RemoveAt(_listWarnaBangunan.Count - 1);
                RefreshDataGrid();
            }
        }
    }
}