namespace Battleship
{
    public class BattleshipPuzzle
    {
        private readonly Board board;

        public BattleshipPuzzle(Board board)
        {
            this.board = board;
        }

        public Result ShootAt(Position position)
        {
            Ship ship = board.GetShipAt(position);

            if (ship == null)
                return Result.Miss;

            ship.Hit(position);
            if (!ship.IsSunken())
                return Result.Hit;

            if (!board.AllShipsSunken())
                return Result.ShipSunk;

            return Result.GameOver;
        }
    }
}