namespace Battleship
{
    public class BattleshipPuzzle
    {
        private readonly Board board = new Board();

        public BattleshipPuzzle(Board board)
        {
            this.board = board;
        }

        public Result ShootAt(Position position)
        {
            if (board.IsThereAShipAt(position))
                return Result.Hit;
            else
                return Result.Miss;
        }
    }
}