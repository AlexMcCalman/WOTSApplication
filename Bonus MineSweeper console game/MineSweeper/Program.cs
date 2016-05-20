using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            //making the board
            Console.WriteLine("How large would you like the board?");
            int boardSize = int.Parse(Console.ReadLine());

            Square[,] board = new Square[boardSize, boardSize];
            
            for(int i=0; i<boardSize; i++)
            {
                for(int j=0; j<boardSize; j++)
                {
                    board[i, j] = new Square(i, j);
                }
            };

            //setting mines
            Console.WriteLine("How hard would you like the game to be?");
            string diff = Console.ReadLine();
            double diffModifier = 0.2;

            switch (diff)
            {
                case "easy":
                    diffModifier = 0.1;
                    break;

                case "medium":
                    diffModifier = 0.2;
                    break;

                case "hard":
                    diffModifier = 0.3;
                    break;

                default:
                    Console.WriteLine("Invalid input - you get an unfair game");
                    diffModifier = 0.7;
                    break;
            }

            double minePercent = (boardSize * boardSize) * diffModifier;
            int totalMines = Convert.ToInt32(Math.Ceiling(minePercent));
            int currentMines = 0;

            while (currentMines < totalMines)
            {
                Random rnd = new Random();
                int mineX = rnd.Next(0, boardSize);
                int mineY = rnd.Next(0, boardSize);

                if (board[mineX, mineY].mine == true)
                    continue;

                else
                {
                    board[mineX, mineY].mine = true;
                    currentMines++;
                }
            }

            //adjCheck
            foreach(Square sq in board)
            {
                if (sq.mine == true)
                    continue;

                else
                {
                    for (int b = (sq.y - 1); b <= (sq.y + 1); b++)
                    {
                        if (b < 0 || b > (boardSize - 1))
                            continue;
                        else
                        {
                            for (int a = (sq.x - 1); a <= (sq.x + 1); a++)
                            {
                                if (a < 0 || a > (boardSize - 1))
                                    continue;
                                if (board[a, b].mine == true)
                                {
                                    sq.minesAdj++;
                                }
                            }
                        }
                    }
                }

            }

            //gameplay
            int gameState = 0;

            while(gameState == 0)
            {
                //setting displays
                foreach (Square sq in board)
                {
                    if (sq.rev == true)
                    {
                        sq.display = sq.minesAdj.ToString();
                    }
                };

                //printing the board
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        Console.Write(board[i, j].display);
                    }
                    Console.Write(Environment.NewLine);
                };

                //accepting user input
                int userX = 0, userY = 0;

                try
                {
                    Console.WriteLine("Which row?");
                    userX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Which column?");
                    userY = int.Parse(Console.ReadLine());
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Invalid input");
                }

                board[userX, userY].rev = true;

                //lose condition
                if (board[userX, userY].mine == true)
                {
                    board[userX, userY].display = "X";
                    gameState++;
                }

                //win condition
                int squaresRev = 0;

                foreach (Square sq in board)
                {
                    if (sq.mine == false && sq.rev == true)
                        squaresRev++;
                }

                if (squaresRev == ((boardSize * boardSize) - totalMines))
                {
                    foreach (Square sq in board)
                    {
                        sq.rev = true;

                        if (sq.mine == true)
                        {
                            sq.display = "X";
                        }

                        else
                        {
                            sq.display = sq.minesAdj.ToString();
                        }
                    }
                    gameState += 2;
                }
            }

            switch (gameState)
            {
                case 1:
                    Console.WriteLine("You lost!");
                    break;

                case 2:
                    Console.WriteLine("You won!");
                    break;
            }

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write(board[i, j].display);
                }
                Console.Write(Environment.NewLine);
            };

            Console.ReadLine();
        }
    }

}
