using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Stick : Figure
    {
        
        public Stick(int x, int y, char sym)
        {
            int m = 0;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Dot(x, y + m, sym);
                m++;
            }
        }


    }
}