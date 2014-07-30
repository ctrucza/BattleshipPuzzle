using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Ship
    {
        private readonly Dictionary<Position, bool> holes = new Dictionary<Position, bool>();

        public Ship(int size, Position position, Orientation orientation)
        {
            int dx = 0;
            int dy = 0;

            if (orientation == Orientation.Horizontal)
            {
                dy = 1;
            }
            else
            {
                dx = 1;
            }

            for (int i = 0; i < size; ++i)
            {
                int x = position.X + i * dx;
                int y = position.Y + i * dy;
                holes.Add(new Position(x, y), true);
            }
        }

        public IEnumerable<Position> Holes()
        {
            return holes.Select(hole => hole.Key);
        }

        public void Hit(Position position)
        {
            if (!holes.ContainsKey(position))
                throw new InvalidHitPositionException();
            holes[position] = false;
        }

        public bool IsSunken()
        {
            return !holes.Any(p => p.Value);
        }
    }
}