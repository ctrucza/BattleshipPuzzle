namespace Battleship
{
    public class Board
    {
        private readonly int[,] board = new int[10, 10];

        public void AddShip(Position position, int size)
        {
            for (int i = 0; i < size; ++i)
            {
                board[position.x, position.y+i] = 1;
            }
        }

        public bool IsThereAShipAt(Position position)
        {
            return (board[position.x, position.y] == 1);
        }
    }
}