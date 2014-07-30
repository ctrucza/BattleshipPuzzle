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

        [Test]
        public void Can_find_ship_at_location()
        {
            Board b = new Board();
            b.AddShip(0,0,1);
            Assert.IsTrue(b.IsThereAShipAt(0,0));
            Assert.IsFalse(b.IsThereAShipAt(1,1));
        }

        [Test]
        public void Ship_can_be_added_correctly()
        {
            Board b = new Board();
            Assert.IsFalse(b.IsThereAShipAt(1,1));
            b.AddShip(1,1,1);
            Assert.IsTrue(b.IsThereAShipAt(1,1));
        }

    }
}
