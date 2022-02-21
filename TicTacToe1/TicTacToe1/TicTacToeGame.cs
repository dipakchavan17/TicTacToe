using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
    public class TicTacToeGame
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
            for(int i = 1;i<=board.Length;i++)
            {
                board[i] = '';

            }
            foreach(char i in board)
            {
                Console.WriteLine(i);

            }



            }       }
    }

