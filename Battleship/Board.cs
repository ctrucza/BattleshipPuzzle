namespace Battleship
{
    public class Board
    {
        private readonly int[,] board = new int[10, 10];

        public void AddShip(Position position)
        {
            board[position.x, position.y] = 1;
        }

        public bool IsThereAShipAt(Position position)
        {
            return (board[position.x, position.y] == 1);
        }
    }
}