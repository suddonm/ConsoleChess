using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class GameController
    {
        private char[][] board;

        public GameController()
        {
            board = new char[8][];
            for (int i = 0; i < 8; i++)
            {
                board[i] = new char[8];
            }
        }

        public char[][] GetBoard()
        {
            return board;
        }
    }
}
