﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peakypaint
{
    public partial class colorpicker : Form
    {
        public Color selected { get; set; }
        public colorpicker()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            Color clr = pixeldata.GetPixel(e.X, e.Y);
            lbColorPreview.BackColor = clr;
            lbColorValue.Text = "R: " + clr.R.ToString() + " G: " + clr.G.ToString() + " B: " + clr.B.ToString(); 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap pixeldata = (Bitmap)pictureBox1.Image;
            selected = pixeldata.GetPixel(e.X, e.Y);
            selectedColorPreview.BackColor = selected;
            nmSelColR.Text = selected.R.ToString();
            nmSelColG.Text = selected.G.ToString();
            nmSelColB.Text = selected.B.ToString();
        }


        private void nmSelColR_ValueChanged(object sender, EventArgs e)
        {
            selected = Color.FromArgb(255, (int)nmSelColR.Value, selected.G, selected.B);
            selectedColorPreview.BackColor = selected;
        }

        private void nmSelColG_ValueChanged(object sender, EventArgs e)
        {
            selected = Color.FromArgb(255, selected.R, (int)nmSelColG.Value, selected.B);
            selectedColorPreview.BackColor = selected;
        }

        private void nmSelColB_ValueChanged(object sender, EventArgs e)
        {
            selected = Color.FromArgb(255, selected.R, selected.G, (int)nmSelColB.Value);
            selectedColorPreview.BackColor = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
