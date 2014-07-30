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
            puzzle = new BattleshipPuzzle();
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
            Result result = puzzle.ShootAt(new Position(0,1));
            Assert.AreEqual(Result.Miss, result);
        }
    }
}
