using System;
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
    public partial class Form1 : Form
    {
        public Color selectedColor { get; set; }
        Bitmap canvas = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool isDrawing = false;
        int brushSize = 5;

        public Form1()
        {
            InitializeComponent();
            selectedColor = Color.Black;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            colorpicker pick = new colorpicker();
            pick.ShowDialog();
            selectedColor = pick.selected;
            colPreview.BackColor = pick.selected;
            pen = new Pen(selectedColor, 5);

        }



        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;

        }

        private void pbCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDrawing)
            { 
                Graphics graphics = Graphics.FromImage(canvas);
                graphics.DrawEllipse(pen, e.X, e.Y, brushSize, brushSize);
                pbCanvas.Image = canvas;
            }
        }

        private void pbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(canvas);
            graphics.DrawEllipse(pen, e.X, e.Y, brushSize, brushSize);
            pbCanvas.Image = canvas;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            brushSize = 5;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            brushSize = 10;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            brushSize = 15;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            brushSize = 20;//kjdaskjdskjasdkldsanlkdsalnmds
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            brushSize = 60;//kjdaskjdskjasdkldsanlkdsalnmds
        }
    }
}
