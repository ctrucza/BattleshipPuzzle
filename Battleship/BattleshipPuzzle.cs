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
            Ship ship = board.GetShipAt(position);
            if (ship == null)
                return Result.Miss;
            ship.HitAt(position);
            if (ship.IsSunken())
                return Result.ShipSunk;
            return Result.Hit;
        }
    }
}