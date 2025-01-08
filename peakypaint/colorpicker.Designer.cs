namespace peakypaint
{
    partial class colorpicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(colorpicker));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbColorPreview = new System.Windows.Forms.Label();
            this.lbColorValue = new System.Windows.Forms.Label();
            this.gbSelCol = new System.Windows.Forms.GroupBox();
            this.selectedColorPreview = new System.Windows.Forms.Label();
            this.lbBValue = new System.Windows.Forms.Label();
            this.lbGValue = new System.Windows.Forms.Label();
            this.lbRValue = new System.Windows.Forms.Label();
            this.nmSelColR = new System.Windows.Forms.NumericUpDown();
            this.nmSelColG = new System.Windows.Forms.NumericUpDown();
            this.nmSelColB = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSelCol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color picker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbColorPreview
            // 
            this.lbColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColorPreview.Location = new System.Drawing.Point(213, 200);
            this.lbColorPreview.Name = "lbColorPreview";
            this.lbColorPreview.Size = new System.Drawing.Size(98, 32);
            this.lbColorPreview.TabIndex = 2;
            this.lbColorPreview.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbColorValue
            // 
            this.lbColorValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColorValue.Location = new System.Drawing.Point(54, 200);
            this.lbColorValue.Name = "lbColorValue";
            this.lbColorValue.Size = new System.Drawing.Size(153, 32);
            this.lbColorValue.TabIndex = 4;
            this.lbColorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSelCol
            // 
            this.gbSelCol.Controls.Add(this.nmSelColB);
            this.gbSelCol.Controls.Add(this.nmSelColG);
            this.gbSelCol.Controls.Add(this.nmSelColR);
            this.gbSelCol.Controls.Add(this.selectedColorPreview);
            this.gbSelCol.Controls.Add(this.lbBValue);
            this.gbSelCol.Controls.Add(this.lbGValue);
            this.gbSelCol.Controls.Add(this.lbRValue);
            this.gbSelCol.Location = new System.Drawing.Point(26, 235);
            this.gbSelCol.Name = "gbSelCol";
            this.gbSelCol.Size = new System.Drawing.Size(308, 172);
            this.gbSelCol.TabIndex = 5;
            this.gbSelCol.TabStop = false;
            this.gbSelCol.Text = "Selected Color";
            // 
            // selectedColorPreview
            // 
            this.selectedColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedColorPreview.Location = new System.Drawing.Point(181, 36);
            this.selectedColorPreview.Name = "selectedColorPreview";
            this.selectedColorPreview.Size = new System.Drawing.Size(108, 91);
            this.selectedColorPreview.TabIndex = 6;
            // 
            // lbBValue
            // 
            this.lbBValue.AutoSize = true;
            this.lbBValue.Location = new System.Drawing.Point(19, 108);
            this.lbBValue.Name = "lbBValue";
            this.lbBValue.Size = new System.Drawing.Size(37, 16);
            this.lbBValue.TabIndex = 3;
            this.lbBValue.Text = "Blue:";
            // 
            // lbGValue
            // 
            this.lbGValue.AutoSize = true;
            this.lbGValue.Location = new System.Drawing.Point(19, 73);
            this.lbGValue.Name = "lbGValue";
            this.lbGValue.Size = new System.Drawing.Size(47, 16);
            this.lbGValue.TabIndex = 2;
            this.lbGValue.Text = "Green:";
            // 
            // lbRValue
            // 
            this.lbRValue.AutoSize = true;
            this.lbRValue.Location = new System.Drawing.Point(19, 36);
            this.lbRValue.Name = "lbRValue";
            this.lbRValue.Size = new System.Drawing.Size(36, 16);
            this.lbRValue.TabIndex = 1;
            this.lbRValue.Text = "Red:";
            // 
            // nmSelColR
            // 
            this.nmSelColR.Location = new System.Drawing.Point(70, 34);
            this.nmSelColR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmSelColR.Name = "nmSelColR";
            this.nmSelColR.Size = new System.Drawing.Size(79, 22);
            this.nmSelColR.TabIndex = 7;
            this.nmSelColR.ValueChanged += new System.EventHandler(this.nmSelColR_ValueChanged);
            // 
            // nmSelColG
            // 
            this.nmSelColG.Location = new System.Drawing.Point(70, 71);
            this.nmSelColG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmSelColG.Name = "nmSelColG";
            this.nmSelColG.Size = new System.Drawing.Size(79, 22);
            this.nmSelColG.TabIndex = 8;
            this.nmSelColG.ValueChanged += new System.EventHandler(this.nmSelColG_ValueChanged);
            // 
            // nmSelColB
            // 
            this.nmSelColB.Location = new System.Drawing.Point(70, 106);
            this.nmSelColB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmSelColB.Name = "nmSelColB";
            this.nmSelColB.Size = new System.Drawing.Size(79, 22);
            this.nmSelColB.TabIndex = 9;
            this.nmSelColB.ValueChanged += new System.EventHandler(this.nmSelColB_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorpicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbSelCol);
            this.Controls.Add(this.lbColorValue);
            this.Controls.Add(this.lbColorPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "colorpicker";
            this.Text = "colorpicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSelCol.ResumeLayout(false);
            this.gbSelCol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSelColB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbColorPreview;
        private System.Windows.Forms.Label lbColorValue;
        private System.Windows.Forms.GroupBox gbSelCol;
        private System.Windows.Forms.Label lbBValue;
        private System.Windows.Forms.Label lbGValue;
        private System.Windows.Forms.Label lbRValue;
        private System.Windows.Forms.Label selectedColorPreview;
        private System.Windows.Forms.NumericUpDown nmSelColR;
        private System.Windows.Forms.NumericUpDown nmSelColB;
        private System.Windows.Forms.NumericUpDown nmSelColG;
        private System.Windows.Forms.Button button1;
    }
}