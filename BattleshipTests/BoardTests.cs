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
            b.AddShip(new Position(0,0));
        }

        [Test]
        public void Can_find_ship_at_location()
        {
            Board b = new Board();
            var position = new Position(0,0);
            b.AddShip(position);

            Assert.IsTrue(b.IsThereAShipAt(position));
        }

        [Test]
        public void Ship_is_added_correctly()
        {
            Board b = new Board();
            var position = new Position(0,0);

            Assert.IsFalse(b.IsThereAShipAt(position));

            b.AddShip(position);
            Assert.IsTrue(b.IsThereAShipAt(position));
        }

    }
}
