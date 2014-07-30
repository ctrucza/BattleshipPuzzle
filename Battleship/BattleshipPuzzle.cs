namespace Battleship
{
    public class BattleshipPuzzle
    {
        private readonly Board board = new Board();

        public BattleshipPuzzle()
        {
            board.AddShip(0, 0);
        }

        public Result ShootAt(int x, int y)
        {
            if (board.IsThereAShipAt(x,y))
                return Result.Hit;
            else
                return Result.Miss;
        }
    }
}