using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        private readonly Dictionary<Position, Ship> board = new Dictionary<Position, Ship>(); 
        private readonly List<Ship> ships = new List<Ship>(); 

        public void AddShip(Ship ship)
        {
            ships.Add(ship);
            foreach (Position hole in ship.Holes())
            {
                board[hole] = ship;
            }
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