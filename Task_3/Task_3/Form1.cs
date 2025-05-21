namespace Task_3
{
    public partial class Form1 : Form
    {
        private List<Figure> figures = new List<Figure>();
        private Random rnd = new Random();
        private Bitmap canvas;

        public Form1()
        {
            InitializeComponent1();
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = canvas;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = rnd.Next(pictureBox1.Width - 100);
            int y = rnd.Next(pictureBox1.Height - 100);
            int x1 = rnd.Next(pictureBox1.Width - 100);
            int y1 = rnd.Next(pictureBox1.Height - 100);
            int x2 = rnd.Next(pictureBox1.Width - 100);
            int y2 = rnd.Next(pictureBox1.Height - 100);
            int x3 = rnd.Next(pictureBox1.Width - 100);
            int y3 = rnd.Next(pictureBox1.Height - 100);

            Color color = Color.Red;
            Color color1 = Color.Blue;
            Color color2 = Color.Green;
            Color color3 = Color.Black;
            // За прикладом - додаємо еліпс
            Figure f = new EllipseFigure(color, x, y, 80, 40);
            Figure f1 = new ArcFigure(color1, x1, y1, 80, 40, 190, 80);
            Figure f2 = new PieFigure(color2, x2, y2, 80, 40, 0, 120);
            Figure f3 = new RoundRectFigure(color3, x3, y3, 80, 40, 20);
            figures.Add(f);
            figures.Add(f1);
            figures.Add(f2);
            figures.Add(f3);

            Redraw();
        }

        private void Redraw()
        {
            using (Graphics g = Graphics.FromImage(canvas))
            {
                g.Clear(Color.White);
                foreach (var fig in figures)
                    fig.Draw(g);
            }
            pictureBox1.Invalidate();
        }
    }

}
