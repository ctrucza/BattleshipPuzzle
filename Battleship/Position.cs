namespace Battleship
{
    public class Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            Position other = obj as Position;
            if (other == null)
                return false;
            return (x == other.x) && (y == other.y);
        }

        public override int GetHashCode()
        {
            return x + y;
        }
    }
}