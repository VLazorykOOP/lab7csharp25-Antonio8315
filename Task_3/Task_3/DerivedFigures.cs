using System.Drawing;
using System.Drawing.Drawing2D;
using Task_3;

public class EllipseFigure : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }

    public EllipseFigure(Color color, int x, int y, int width, int height)
        : base(color, x, y)
    {
        Width = width;
        Height = height;
    }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        {
            g.DrawEllipse(pen, X, Y, Width, Height);
        }
    }
}

public class ArcFigure : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public float StartAngle { get; set; }
    public float SweepAngle { get; set; }

    public ArcFigure(Color color, int x, int y, int width, int height, float startAngle, float sweepAngle)
        : base(color, x, y)
    {
        Width = width;
        Height = height;
        StartAngle = startAngle;
        SweepAngle = sweepAngle;
    }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        {
            g.DrawArc(pen, X, Y, Width, Height, StartAngle, SweepAngle);
        }
    }
}

public class PieFigure : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public float StartAngle { get; set; }
    public float SweepAngle { get; set; }

    public PieFigure(Color color, int x, int y, int width, int height, float startAngle, float sweepAngle)
        : base(color, x, y)
    {
        Width = width;
        Height = height;
        StartAngle = startAngle;
        SweepAngle = sweepAngle;
    }

    public override void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(Color))
        {
            g.FillPie(brush, X, Y, Width, Height, StartAngle, SweepAngle);
        }
    }
}

public class RoundRectFigure : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int Radius { get; set; }

    public RoundRectFigure(Color color, int x, int y, int width, int height, int radius)
        : base(color, x, y)
    {
        Width = width;
        Height = height;
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        using (GraphicsPath path = new GraphicsPath())
        {
            int r = Radius;
            Rectangle rect = new Rectangle(X, Y, Width, Height);
            path.AddArc(rect.Left, rect.Top, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Top, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            g.DrawPath(pen, path);
        }
    }
}
