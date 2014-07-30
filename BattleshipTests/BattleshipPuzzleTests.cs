using NUnit.Framework;
using Battleship;

namespace BattleshipTests
{
    [TestFixture]
    public class BattleshipPuzzleTests
    {
        private static BattleshipPuzzle puzzle;

        [SetUp]
        public void CreateNewPuzzle()
        {
            var board = CreateBoard();
            puzzle = new BattleshipPuzzle(board);
        }

        private static Board CreateBoard()
        {
            var board = new Board();
            var position = new Position(0, 0);
            board.AddShip(new Ship(2, position, Orientation.Horizontal));
            return board;
        }

        [Test]
        public void Shooting_at_a_ship_hits_it()
        {
            Result result = puzzle.ShootAt(new Position(0,0));
            Assert.AreEqual(Result.Hit, result);
        }

        [Test]
        public void Shooting_in_water_misses()
        {
            Result result = puzzle.ShootAt(new Position(0,2));
            Assert.AreEqual(Result.Miss, result);
        }

        [Test]
        public void Shooting_all_holes_of_a_ship_sinks_it()
        {
            var b = new Board();
            b.AddShip(new Ship(2, new Position(5,5), Orientation.Horizontal));
            // we need another ship, or sinking the only one will result in game over
            b.AddShip(new Ship(1, new Position(0,0), Orientation.Horizontal));
            puzzle = new BattleshipPuzzle(b);

            Assert.AreEqual(Result.Hit, puzzle.ShootAt(new Position(5,5)));
            Assert.AreEqual(Result.ShipSunk, puzzle.ShootAt(new Position(5,6)));
        }

        [Test]
        public void Sinking_all_ships_ends_the_game()
        {
            var b = new Board();
            b.AddShip(new Ship(2, new Position(5, 5), Orientation.Horizontal));
            puzzle = new BattleshipPuzzle(b);

            Assert.AreEqual(Result.Hit, puzzle.ShootAt(new Position(5, 5)));
            Assert.AreEqual(Result.GameOver, puzzle.ShootAt(new Position(5, 6)));

        }
    }
}
