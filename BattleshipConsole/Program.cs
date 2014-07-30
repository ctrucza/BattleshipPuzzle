using System;
using Battleship;

namespace BattleshipConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = BuildBoard();

            BattleshipPuzzle puzzle = new BattleshipPuzzle(board);

            while (true)
            {
                var position = ReadNextShot();

                try
                {
                    Result result = puzzle.ShootAt(position);
                    Console.WriteLine(result);

                    if (result == Result.GameOver)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static Board BuildBoard()
        {
            var board = new Board();
            board.AddShip(new Ship(5, new Position(3, 3), Orientation.Horizontal));
            board.AddShip(new Ship(4, new Position(4, 5), Orientation.Vertical));

            return board;
        }

        private static Position ReadNextShot()
        {
            while (true)
            {
                Console.Write("Aim:");
                string s = Console.ReadLine();
                string[] strings = s.Split(' ');

                try
                {
                    int x = int.Parse(strings[0]);
                    int y = int.Parse(strings[1]);
                    Position position = new Position(x, y);
                    return position;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
