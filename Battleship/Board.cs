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

            // we make it a list so we don't enumerate it twice
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

        public Ship GetShipAt(Position position)
        {
            if (!IsValidPosition(position))
                throw new InvalidPositionException();

            if (board.ContainsKey(position))
                return board[position];
            return null;
        }

        public bool AllShipsSunken()
        {
            return ships.All(s => s.IsSunken());
        }

        private static bool IsValidPosition(Position hole)
        {
            return hole.X >= 0 && hole.X < height && hole.Y >= 0 && hole.Y < width;
        }
    }
}