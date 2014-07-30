namespace Battleship
{
    public class Board
    {
        private readonly Ship[,] board = new Ship[10, 10];

        public void AddShip(Position position, Ship ship, Orientation orientation)
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

            for (int i = 0; i < ship.Size; ++i)
            {
                board[position.x+i*dx, position.y+i*dy] = ship;
            }
        }

        public Ship GetShipAt(Position position)
        {
            return board[position.x, position.y];
        }
    }
}