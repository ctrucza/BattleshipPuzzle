using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        private readonly Dictionary<Position, Ship> board = new Dictionary<Position, Ship>(); 
        private readonly List<Ship> ships = new List<Ship>();

        private const int width = 10;
        private const int height = 10;

        public void AddShip(Ship ship)
        {
            ships.Add(ship);

            List<Position> holes = ship.Holes().ToList();

            if (holes.Any(hole => !IsValidPosition(hole)))
            {
                throw new InvalidPositionException();
            }

            foreach (Position hole in holes)
            {
                board[hole] = ship;
            }
        }

        private static bool IsValidPosition(Position hole)
        {
            return hole.X >= 0 && hole.X < height && hole.Y >= 0 && hole.Y < width;
        }

        public Ship GetShipAt(Position position)
        {
            if (board.ContainsKey(position))
                return board[position];
            return null;
        }

        public bool AllShipsSunken()
        {
            return ships.All(s => s.IsSunken());
        }
    }
}