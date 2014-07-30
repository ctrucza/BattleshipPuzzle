namespace Battleship
{
    public class Board
    {
        private readonly int[,] board = new int[10, 10];

        public void AddShip(int x, int y)
        {
            board[x, y] = 1;
        }

        public bool IsThereAShipAt(int x, int y)
        {
            return (board[x, y] == 1);
        }
    }
}