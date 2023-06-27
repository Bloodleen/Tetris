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

        public enum Direction
        {
            left = 1, right, down
        }

        public void Move(Direction dir)
        {
            foreach(Dot p in points)
            {
                switch (dir)
                {
                    case Direction.left:
                        p.x -= 1; 
                        break;
                    case Direction.right:
                        p.x += 1;
                        break;
                    case Direction.down: 
                        p.y += 1; 
                        break;
                }
            }
        }

        public void Hide()
        {
            foreach (Dot p in points)
            {
                p.Hide();
            }
        }

    }
}
