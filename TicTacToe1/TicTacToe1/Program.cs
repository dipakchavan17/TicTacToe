using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TiTacToe");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
                Console.ReadLine();
        }
    }
}
