using NUnit.Framework;
using Battleship;

namespace BattleshipTests
{
    [TestFixture]
    class BattleshipTests
    {
        [Test]
        public void Test_usage()
        {
            var battleship = new BattleshipPuzzle();
            battleship.ShootAt(0, 0);
        }
    }
}
