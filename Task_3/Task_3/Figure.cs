using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public abstract class Figure
    {
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Figure(Color color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }

        public abstract void Draw(Graphics g);
    }
}
