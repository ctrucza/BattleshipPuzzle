using System.Collections.Generic;
using System.Linq;

namespace Battleship
{
    public class Ship
    {
        public int Size;
        private Dictionary<Position, bool> holes = new Dictionary<Position, bool>();

        public Ship(int size, Position position)
        {
            for(int i = 0; i < size; ++i)
                holes.Add(new Position(position.x, position.y+i), true);
            Size = size;
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