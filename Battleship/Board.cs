using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        private readonly Ship[,] board = new Ship[10, 10];
        private readonly List<Ship> ships = new List<Ship>(); 

        public void AddShip(Position position, Ship ship, Orientation orientation)
        {
            ships.Add(ship);
            foreach (Position hole in ship.Holes())
            {
                board[hole.x, hole.y] = ship;
            }
        }

        public Ship GetShipAt(Position position)
        {
            return board[position.x, position.y];
        }

        public bool AllShipsSunken()
        {
            return ships.All(s => s.IsSunken());
        }
    }
}