using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Square
    {
        public bool mine = false;
        public int minesAdj = 0;
        public bool rev = false;
        public bool flagged = false;
        public int x;
        public int y;
        public string display = "/";

        public Square(int a, int b)
        {
            x = a;
            y = b;
        }

       }
}
