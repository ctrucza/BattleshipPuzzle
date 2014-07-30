using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        private readonly List<Ship> ships = new List<Ship>();

        private const int width = 10;
        private const int height = 10;

        public void AddShip(Ship ship)
        {
            ValidateShip(ship);
            ships.Add(ship);
        }

        private void ValidateShip(Ship ship)
        {
            if (ship.Holes().Any(hole => !IsValidPosition(hole)))
            {
                throw new InvalidPositionException();
            }
        }

        public Ship GetShipAt(Position position)
        {
            if (!IsOnBoard(position))
                throw new InvalidPositionException();

            return ships.SingleOrDefault(ship => ship.Contains(position));
        }

        public bool AllShipsSunken()
        {
            return ships.All(s => s.IsSunken());
        }

        private bool IsValidPosition(Position hole)
        {
            return IsOnBoard(hole) && IsUnoccupied(hole);
        }

        private static bool IsOnBoard(Position hole)
        {
            return hole.X >= 0 && hole.X < height && hole.Y >= 0 && hole.Y < width;
        }

        private bool IsUnoccupied(Position hole)
        {
            return GetShipAt(hole) == null;
        }
    }
}