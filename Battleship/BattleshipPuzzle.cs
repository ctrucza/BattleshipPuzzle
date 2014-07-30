namespace Battleship
{
    public class BattleshipPuzzle
    {
        private readonly Board board = new Board();

        public BattleshipPuzzle()
        {
            board.AddShip(new Position(0,0), 1);
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