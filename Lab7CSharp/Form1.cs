using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Color currentColor = Color.Black;
        private Bitmap canvasBitmap;
        private Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(panel1.Width, panel1.Height);
            graphics = Graphics.FromImage(canvasBitmap);
            graphics.Clear(Color.White);
            panel1.BackgroundImage = canvasBitmap;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                isDrawing = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                graphics.FillEllipse(new SolidBrush(currentColor), e.X, e.Y, 5, 5);
                panel1.Invalidate();
            }
        }

        private void btnNewPicture_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            panel1.Invalidate();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked) currentColor = Color.Red;
            else if (radioButtonGreen.Checked) currentColor = Color.Green;
            else if (radioButtonBlue.Checked) currentColor = Color.Blue;
            else if (radioButtonBlack.Checked) currentColor = Color.Black;
        }
    }
}
