namespace UAS_PCD
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownMinJmlPiksel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownClosing = new System.Windows.Forms.NumericUpDown();
            this.labelClosing = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPilihFolder = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownOpening = new System.Windows.Forms.NumericUpDown();
            this.labelOpening = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewHsvColor = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinJmlPiksel)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosing)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpening)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHsvColor)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownMinJmlPiksel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 44);
            this.panel4.TabIndex = 3;
            // 
            // numericUpDownMinJmlPiksel
            // 
            this.numericUpDownMinJmlPiksel.Location = new System.Drawing.Point(189, 10);
            this.numericUpDownMinJmlPiksel.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownMinJmlPiksel.Name = "numericUpDownMinJmlPiksel";
            this.numericUpDownMinJmlPiksel.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownMinJmlPiksel.TabIndex = 1;
            this.numericUpDownMinJmlPiksel.Value = new decimal(new int[] {
            5452,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimal Jumlah Piksel/Blob";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownClosing);
            this.panel3.Controls.Add(this.labelClosing);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 44);
            this.panel3.TabIndex = 2;
            // 
            // numericUpDownClosing
            // 
            this.numericUpDownClosing.Location = new System.Drawing.Point(189, 10);
            this.numericUpDownClosing.Name = "numericUpDownClosing";
            this.numericUpDownClosing.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownClosing.TabIndex = 1;
            this.numericUpDownClosing.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownClosing.ValueChanged += new System.EventHandler(this.numericUpDownClosing_ValueChanged);
            // 
            // labelClosing
            // 
            this.labelClosing.AutoSize = true;
            this.labelClosing.Location = new System.Drawing.Point(7, 14);
            this.labelClosing.Name = "labelClosing";
            this.labelClosing.Size = new System.Drawing.Size(138, 13);
            this.labelClosing.TabIndex = 0;
            this.labelClosing.Text = "Besar Kernel Closing (3 X 3)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPilihFolder);
            this.panel1.Controls.Add(this.textBoxFolderPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 44);
            this.panel1.TabIndex = 0;
            // 
            // buttonPilihFolder
            // 
            this.buttonPilihFolder.Location = new System.Drawing.Point(449, 15);
            this.buttonPilihFolder.Name = "buttonPilihFolder";
            this.buttonPilihFolder.Size = new System.Drawing.Size(102, 23);
            this.buttonPilihFolder.TabIndex = 1;
            this.buttonPilihFolder.Text = "Pilih Folder Citra";
            this.buttonPilihFolder.UseVisualStyleBackColor = true;
            this.buttonPilihFolder.Click += new System.EventHandler(this.buttonPilihFolder_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(7, 16);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(433, 20);
            this.textBoxFolderPath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownOpening);
            this.panel2.Controls.Add(this.labelOpening);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 44);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDownOpening
            // 
            this.numericUpDownOpening.Location = new System.Drawing.Point(189, 10);
            this.numericUpDownOpening.Name = "numericUpDownOpening";
            this.numericUpDownOpening.Size = new System.Drawing.Size(162, 20);
            this.numericUpDownOpening.TabIndex = 1;
            this.numericUpDownOpening.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownOpening.ValueChanged += new System.EventHandler(this.numericUpDownOpening_ValueChanged);
            // 
            // labelOpening
            // 
            this.labelOpening.AutoSize = true;
            this.labelOpening.Location = new System.Drawing.Point(7, 14);
            this.labelOpening.Name = "labelOpening";
            this.labelOpening.Size = new System.Drawing.Size(144, 13);
            this.labelOpening.TabIndex = 0;
            this.labelOpening.Text = "Besar Kernel Opening (3 X 3)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Warna Atap Bangunan";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewHsvColor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(558, 149);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewHsvColor
            // 
            this.dataGridViewHsvColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHsvColor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewHsvColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHsvColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHsvColor.Location = new System.Drawing.Point(3, 53);
            this.dataGridViewHsvColor.Name = "dataGridViewHsvColor";
            this.dataGridViewHsvColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHsvColor.Size = new System.Drawing.Size(552, 93);
            this.dataGridViewHsvColor.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonHapus);
            this.panel5.Controls.Add(this.buttonTambah);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(552, 44);
            this.panel5.TabIndex = 0;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(379, 14);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 1;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Location = new System.Drawing.Point(470, 14);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(75, 23);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonCancel);
            this.panel6.Controls.Add(this.buttonOk);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 377);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(564, 44);
            this.panel6.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(365, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(149, 12);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 424);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOptions";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinJmlPiksel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpening)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHsvColor)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPilihFolder;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownOpening;
        private System.Windows.Forms.Label labelOpening;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownClosing;
        private System.Windows.Forms.Label labelClosing;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownMinJmlPiksel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewHsvColor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}