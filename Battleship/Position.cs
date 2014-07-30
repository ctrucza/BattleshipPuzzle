namespace Battleship
{
    public class Position
    {
        public readonly int X;
        public readonly int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Position other = obj as Position;
            if (other == null)
                return false;
            return (X == other.X) && (Y == other.Y);
        }

        public override int GetHashCode()
        {
            return X + Y;
        }
    }
}