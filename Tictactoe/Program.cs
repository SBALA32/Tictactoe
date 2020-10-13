using System;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            Initialize(board);
            print(board);
            for (int i= 0;i < 9;i++)
            {
                chkplr(board);
            }
        }
        static void Initialize(char[,] board)
        {
            for (int row = 1; row <= 3; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }
        static void print(char[,] board)
        {
            for (int row = 1; row <= 3; row++)
            {
                Console.Write("| ");
                for (int col = 1; col <= 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
        static void chkplr(char[,] board)
        {
            Console.WriteLine("Enter player");
            int plr = Convert.ToInt32(Console.ReadLine());
            if (plr == 1)
                takeinput1(board);
            else
                takeinput2(board);
            print(board);
        }
        static void takeinput1(char[,] board)
        {
            char player = 'x';
            Console.Write("Please enter row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter col : ");
            int col = Convert.ToInt32(Console.ReadLine());
            board[row - 1, col - 1] = player;
        }
        static void takeinput2(char[,] board)
        {
            char player = 'o';
            Console.Write("Please enter row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter col : ");
            int col = Convert.ToInt32(Console.ReadLine());
            board[row - 1, col - 1] = player;
        }
    }
}
