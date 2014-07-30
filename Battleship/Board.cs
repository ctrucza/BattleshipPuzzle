namespace Battleship
{
    public class Board
    {
        private readonly Ship[,] board = new Ship[10, 10];

        public void AddShip(Position position, int size, Orientation orientation)
        {
            Ship s = new Ship();
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
                board[position.x+i*dx, position.y+i*dy] = s;
            }
        }

        public bool IsThereAShipAt(Position position)
        {
            return (board[position.x, position.y] != null);
        }

        public Ship GetShipAt(Position position)
        {
            return board[position.x, position.y];
        }
    }
}