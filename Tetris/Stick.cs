using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Stick : Figure
    {

        bool b = true;
        
        public Stick(int x, int y, char sym)
        {
            int m = 0;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Dot(x, y + m, sym);
                m++;
            }
        }

        public override void Rotate()
        {
            int g = -2;
            int n = points[2].x;
            int m = points[2].y;
            for (int i = 0; i < points.Length; i++)
            {
                switch (b)
                {
                    case true:
                        {
                            points[i] = new Dot(n + g, m, '*');
                            break;
                        }
                    case false:
                        {
                            points[i] = new Dot(n, m + g, '*');
                            break;
                        }
                }
                g++;
            }
            b = !b;
        }


    }
}