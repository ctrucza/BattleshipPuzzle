namespace Battleship
{
    public class BattleshipPuzzle
    {
        private int[,] board = new int[10,10];

        public BattleshipPuzzle()
        {
            AddShip(0, 1, 1);
        }

        private void AddShip(int x, int y, int size)
        {
            for (int i = 0; i < size; ++i)
                board[x, y + i] = 1;
        }

        public Result ShootAt(int x, int y)
        {
            if (board[x, y] == 0)
                return Result.Miss;
            else
                return Result.Hit;
        }
    }
}