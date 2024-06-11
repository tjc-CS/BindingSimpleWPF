using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Board
    {
        private int colour = 5;
        public Board()
        {

        }

        public void ChangeSomething()
        {

            colour = colour + 1;
        }
        public int col
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
