using NUnit.Framework;
using Battleship;

namespace BattleshipTests
{
    [TestFixture]
    internal class BattleshipPuzzleTests
    {
        [Test]
        public void Test_usage()
        {
            var battleship = new BattleshipPuzzle();
            battleship.ShootAt(0, 0);
        }

        [Test]
        public void Shooting_in_water_misses()
        {
            var battleship = new BattleshipPuzzle();
            var result = battleship.ShootAt(0, 0);
            Assert.AreEqual(Result.Miss, result);
        }
    }
}
