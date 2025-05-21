using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private float x = 0.1f;
        private Graphics g;
        private Pen graphPen = new Pen(Color.Blue, 2);
        private Font drawFont = new Font("Arial", 10);
        private Brush fontBrush = Brushes.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            x = 0.1f;
            pictureBox1.Invalidate();
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x >= 4.0f)
            {
                timer1.Stop();
                return;
            }

            float step = 0.05f;
            float y = (float)(Math.Sin(x) / x);

            // масштабування
            float px = x * 100;
            float py = 150 - y * 100;

            g.FillEllipse(graphPen.Brush, px, py, 4, 4);
            x += step;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                drawFont = fontDialog1.Font;
                fontBrush = new SolidBrush(fontDialog1.Color);
                using (Graphics g = pictureBox1.CreateGraphics())
                {
                    g.DrawString("y = sin(x)/x", drawFont, fontBrush, new PointF(10, 10));
                }
            }
        }
    }
}

