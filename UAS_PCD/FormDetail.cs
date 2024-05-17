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
    public partial class FormDetail : Form
    {
        public FormDetail()
        {
            InitializeComponent();
        }

        public void SetImages(Dictionary<string, Bitmap> images)
        {
            var list = images.ToList();

            groupBox1.Text = list[0].Key;
            customPictureBox1.Image = list[0].Value;

            groupBox2.Text = list[1].Key;
            customPictureBox2.Image = list[1].Value;

            groupBox3.Text = list[2].Key;
            customPictureBox3.Image = list[2].Value;

            groupBox4.Text = list[3].Key;
            customPictureBox4.Image = list[3].Value;

            groupBox5.Text = list[4].Key;
            customPictureBox5.Image = list[4].Value;

            groupBox6.Text = list[5].Key;
            customPictureBox6.Image = list[5].Value;

            groupBox7.Text = list[6].Key;
            customPictureBox7.Image = list[6].Value;

            groupBox8.Text = list[7].Key;
            customPictureBox8.Image = list[7].Value;

            groupBox9.Text = list[8].Key;
            customPictureBox9.Image = list[8].Value;
        }
    }
}
