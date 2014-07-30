using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Ship
    {
        private readonly Dictionary<Position, bool> holes = new Dictionary<Position, bool>();

        public Ship(int size, Position position, Orientation orientation = Orientation.Horizontal)
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
                int x = position.x + i * dx;
                int y = position.y + i * dy;
                holes.Add(new Position(x, y), true);
            }
        }

        public IEnumerable<Position> Holes()
        {
            foreach (var hole in holes)
            {
                yield return hole.Key;
            }
        } 

        public void HitAt(Position position)
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