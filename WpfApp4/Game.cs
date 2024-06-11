using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class Game
    {
        private Board b;
        public Game()
        {
            b = new Board();
        }

        public void ChangeSomething()
        {
            b.ChangeSomething();
        }
        public Board board
        {
            get { return b; }
            set { b = value; }
        }
    }
}
