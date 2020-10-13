using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            Initialize(board);
            print(board);
            toss(board);
            for (int i= 1;i < 9;i++)
            {
                chkplr(board);
            }
        }
        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }
        static void print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < 3; col++)
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
            else if (plr == 2)
                takeinput2(board);
            else
                Console.WriteLine("Invalid Player");
        }
        static void takeinput1(char[,] board)
        {
            char player = 'x';
            Console.Write("Please enter row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter col : ");
            int col = Convert.ToInt32(Console.ReadLine());
            chkposition(board, row, col);
            board[row - 1, col - 1] = player;
            print(board);
        }
        static void takeinput2(char[,] board)
        {
            char player = 'o';
            Console.Write("Please enter row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter col : ");
            int col = Convert.ToInt32(Console.ReadLine());
            chkposition(board, row, col);
            board[row - 1, col - 1] = player;
            print(board);
        }
        static void chkposition(char[,] board, int row, int col)
        {
            int c = col - 1;
            int r = row - 1;
            char v = Convert.ToChar(" ");
            if (board[r, c] == v)
            {
                return;
            }
            else
            {
                Console.WriteLine("Occupied Position");
                chkplr(board);
            }
        }
        static void toss(char[,] board)
        {
            int head = 1;
            int tail = 2;
            Random random = new Random();
            int toss = random.Next(1, 3);
            if (toss == head)
            {
                Console.WriteLine("Start player is User");
                takeinput1(board);
            }
            else
            {
                Console.WriteLine("Start player is Computer");
                takeinput2(board);
            }
        }
    }
}
