using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Square : Figure
    {
        public Square(int x, int y, char sym)
        {
            points[0] = new Dot(x, y, sym);
            points[1] = new Dot(x + 1, y, sym);
            points[2] = new Dot(x, y + 1, sym);
            points[3] = new Dot(x + 1, y + 1, sym);
        }

        public override void Rotate()
        {

        }

    }

}
