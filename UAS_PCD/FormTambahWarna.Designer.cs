namespace UAS_PCD
{
    partial class FormTambahWarna
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
            this.panelLowHigh = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownHighValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowSaturation = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHighHue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLowHue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLowHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowHue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLowHigh
            // 
            this.panelLowHigh.Controls.Add(this.buttonOk);
            this.panelLowHigh.Controls.Add(this.numericUpDownHighValue);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowValue);
            this.panelLowHigh.Controls.Add(this.numericUpDownHighSaturation);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowSaturation);
            this.panelLowHigh.Controls.Add(this.numericUpDownHighHue);
            this.panelLowHigh.Controls.Add(this.numericUpDownLowHue);
            this.panelLowHigh.Controls.Add(this.label7);
            this.panelLowHigh.Controls.Add(this.label6);
            this.panelLowHigh.Controls.Add(this.label5);
            this.panelLowHigh.Controls.Add(this.label4);
            this.panelLowHigh.Controls.Add(this.label3);
            this.panelLowHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLowHigh.Location = new System.Drawing.Point(0, 0);
            this.panelLowHigh.Name = "panelLowHigh";
            this.panelLowHigh.Size = new System.Drawing.Size(264, 151);
            this.panelLowHigh.TabIndex = 9;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(92, 116);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // numericUpDownHighValue
            // 
            this.numericUpDownHighValue.Location = new System.Drawing.Point(194, 74);
            this.numericUpDownHighValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownHighValue.Name = "numericUpDownHighValue";
            this.numericUpDownHighValue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighValue.TabIndex = 10;
            this.numericUpDownHighValue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownLowValue
            // 
            this.numericUpDownLowValue.Location = new System.Drawing.Point(194, 48);
            this.numericUpDownLowValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLowValue.Name = "numericUpDownLowValue";
            this.numericUpDownLowValue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowValue.TabIndex = 9;
            // 
            // numericUpDownHighSaturation
            // 
            this.numericUpDownHighSaturation.Location = new System.Drawing.Point(126, 74);
            this.numericUpDownHighSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownHighSaturation.Name = "numericUpDownHighSaturation";
            this.numericUpDownHighSaturation.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighSaturation.TabIndex = 8;
            this.numericUpDownHighSaturation.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownLowSaturation
            // 
            this.numericUpDownLowSaturation.Location = new System.Drawing.Point(126, 48);
            this.numericUpDownLowSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownLowSaturation.Name = "numericUpDownLowSaturation";
            this.numericUpDownLowSaturation.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowSaturation.TabIndex = 7;
            // 
            // numericUpDownHighHue
            // 
            this.numericUpDownHighHue.Location = new System.Drawing.Point(64, 74);
            this.numericUpDownHighHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownHighHue.Name = "numericUpDownHighHue";
            this.numericUpDownHighHue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownHighHue.TabIndex = 6;
            // 
            // numericUpDownLowHue
            // 
            this.numericUpDownLowHue.Location = new System.Drawing.Point(64, 48);
            this.numericUpDownLowHue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownLowHue.Name = "numericUpDownLowHue";
            this.numericUpDownLowHue.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownLowHue.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "High";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Low";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saturation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hue";
            // 
            // FormTambahWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 151);
            this.ControlBox = false;
            this.Controls.Add(this.panelLowHigh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTambahWarna";
            this.Text = "FormTambahWarna";
            this.panelLowHigh.ResumeLayout(false);
            this.panelLowHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHighHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLowHue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLowHigh;
        private System.Windows.Forms.NumericUpDown numericUpDownHighValue;
        private System.Windows.Forms.NumericUpDown numericUpDownLowValue;
        private System.Windows.Forms.NumericUpDown numericUpDownHighSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownLowSaturation;
        private System.Windows.Forms.NumericUpDown numericUpDownHighHue;
        private System.Windows.Forms.NumericUpDown numericUpDownLowHue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOk;
    }
}