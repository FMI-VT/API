namespace API
{
    partial class Form1
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
            this.labelSourceImages = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxTargetSize = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelTimes = new System.Windows.Forms.Label();
            this.resize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTargetFormat = new System.Windows.Forms.Label();
            this.comboBoxTargetFormat = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxTargetSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSourceImages
            // 
            this.labelSourceImages.Location = new System.Drawing.Point(12, 34);
            this.labelSourceImages.Name = "labelSourceImages";
            this.labelSourceImages.Size = new System.Drawing.Size(141, 33);
            this.labelSourceImages.TabIndex = 22;
            this.labelSourceImages.Text = "Source Images:";
            this.labelSourceImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpen
            // 
            this.buttonOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOpen.Location = new System.Drawing.Point(166, 34);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(120, 33);
            this.buttonOpen.TabIndex = 23;
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(16, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 266);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxTargetSize
            // 
            this.groupBoxTargetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTargetSize.Controls.Add(this.textBox3);
            this.groupBoxTargetSize.Controls.Add(this.textBox4);
            this.groupBoxTargetSize.Controls.Add(this.labelTimes);
            this.groupBoxTargetSize.Location = new System.Drawing.Point(293, 34);
            this.groupBoxTargetSize.Name = "groupBoxTargetSize";
            this.groupBoxTargetSize.Size = new System.Drawing.Size(358, 90);
            this.groupBoxTargetSize.TabIndex = 26;
            this.groupBoxTargetSize.TabStop = false;
            this.groupBoxTargetSize.Text = "Target Size";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 34);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 33);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 26);
            this.textBox4.TabIndex = 10;
            // 
            // labelTimes
            // 
            this.labelTimes.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimes.Location = new System.Drawing.Point(168, 28);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(13, 34);
            this.labelTimes.TabIndex = 9;
            this.labelTimes.Text = "ґ";
            this.labelTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.Location = new System.Drawing.Point(447, 148);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(204, 34);
            this.resize.TabIndex = 29;
            this.resize.Text = "Resize and Convert";
            this.resize.Click += new System.EventHandler(this.resize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelTargetFormat);
            this.groupBox1.Controls.Add(this.comboBoxTargetFormat);
            this.groupBox1.Location = new System.Drawing.Point(300, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 105);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Format";
            // 
            // labelTargetFormat
            // 
            this.labelTargetFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTargetFormat.Location = new System.Drawing.Point(7, 49);
            this.labelTargetFormat.Name = "labelTargetFormat";
            this.labelTargetFormat.Size = new System.Drawing.Size(141, 34);
            this.labelTargetFormat.TabIndex = 24;
            this.labelTargetFormat.Text = "Target Format:";
            this.labelTargetFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTargetFormat
            // 
            this.comboBoxTargetFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetFormat.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "GIF",
            "JPEG"});
            this.comboBoxTargetFormat.Location = new System.Drawing.Point(154, 55);
            this.comboBoxTargetFormat.Name = "comboBoxTargetFormat";
            this.comboBoxTargetFormat.Size = new System.Drawing.Size(189, 28);
            this.comboBoxTargetFormat.TabIndex = 25;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Location = new System.Drawing.Point(531, 350);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(120, 34);
            this.buttonConvert.TabIndex = 31;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 418);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resize);
            this.Controls.Add(this.groupBoxTargetSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelSourceImages);
            this.Name = "Form1";
            this.Text = "Converter and Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxTargetSize.ResumeLayout(false);
            this.groupBoxTargetSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSourceImages;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxTargetSize;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Button resize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTargetFormat;
        private System.Windows.Forms.ComboBox comboBoxTargetFormat;
        private System.Windows.Forms.Button buttonConvert;
    }
}

