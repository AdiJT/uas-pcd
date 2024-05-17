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
    public partial class FormTambahWarna : Form
    {
        public FormTambahWarna()
        {
            InitializeComponent();
        }

        public HsvColorRange Warna
        {
            get => new HsvColorRange(
                new int[]
                {
                    (int)numericUpDownLowHue.Value,
                    (int)numericUpDownLowSaturation.Value,
                    (int)numericUpDownLowValue.Value
                },
                new int[]
                {
                    (int)numericUpDownHighHue.Value,
                    (int)numericUpDownHighSaturation.Value,
                    (int)numericUpDownHighValue.Value
                });
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
