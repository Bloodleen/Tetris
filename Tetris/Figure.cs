using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Figure
    {
        protected Dot[] points = new Dot[4];

        public void Draw()
        {
            foreach (Dot p in points)
            {
                p.Draw();
            }
        }

    }
}
