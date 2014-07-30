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
            b.AddShip(0, 0);
        }

        [Test]
        public void Can_find_ship_at_location()
        {
            Board b = new Board();
            b.AddShip(0,0);
            Assert.IsTrue(b.IsThereAShipAt(0,0));
        }

        [Test]
        public void Ship_is_added_correctly()
        {
            Board b = new Board();
            Assert.IsFalse(b.IsThereAShipAt(0,0));
            b.AddShip(0,0);
            Assert.IsTrue(b.IsThereAShipAt(0,0));
        }

    }
}
