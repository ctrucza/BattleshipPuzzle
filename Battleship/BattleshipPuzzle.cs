namespace Battleship
{
    public class BattleshipPuzzle
    {
        public Result ShootAt(int x, int y)
        {
            if (y==1)
                return Result.Hit;
            else
                return Result.Miss;
        }
    }
}