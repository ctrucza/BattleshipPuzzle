using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        private const int width = 10;
        private const int height = 10;

        private readonly List<Ship> ships = new List<Ship>();

        public void AddShip(Ship ship)
        {
            if (!IsValidShip(ship))
                throw new InvalidShipException();
            ships.Add(ship);
        }

        private bool IsValidShip(Ship ship)
        {
            return ship.Holes().All(IsValidPosition);
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
    }
}