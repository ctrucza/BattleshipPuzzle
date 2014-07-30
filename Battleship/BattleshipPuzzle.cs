namespace Battleship
{
    public class BattleshipPuzzle
    {
        private readonly Board board = new Board();

        public BattleshipPuzzle(Board board)
        {
            this.board = board;
        }

        public Board Board
        {
            get { return board; }
        }
    }
}