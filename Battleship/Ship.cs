using System.Collections.Generic;

namespace Battleship
{
    public class Ship
    {
        public int Size;
        private List<Position> holes = new List<Position>();

        public Ship(int size, Position position)
        {
            for(int i = 0; i < size; ++i)
                holes.Add(new Position(position.x, position.y+i));
            Size = size;
        }

        public void HitAt(Position position)
        {
            if (!holes.Contains(position))
                throw new InvalidHitPositionException();
        }
    }
}