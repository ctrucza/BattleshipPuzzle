namespace Battleship
{
    public class Board
    {
        private readonly int[,] board = new int[10, 10];

        public void AddShip(Position position, int size, Orientation orientation)
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
                board[position.x+i*dx, position.y+i*dy] = 1;
            }
        }

        public bool IsThereAShipAt(Position position)
        {
            return (board[position.x, position.y] == 1);
        }
    }
}