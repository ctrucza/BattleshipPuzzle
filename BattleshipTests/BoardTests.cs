using NUnit.Framework;
using Battleship;

namespace BattleshipTests
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void Test_usage()
        {
            Board b = new Board();
            b.AddShip(0, 0, 1);
        }
    }
}
