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
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';

            }
        }
            public void toss()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            if(value == 0)
            {
                
                Console.WriteLine("(cmputer inputs 'x'");
            }
            if(value==1)
            {

               
                Console.WriteLine("( User inputs 'o'");

            }
        }
           



        
    }

}

