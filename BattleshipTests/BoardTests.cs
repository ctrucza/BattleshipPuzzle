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
            b.AddShip(new Position(0,0), 1, Orientation.Horizontal);
        }

        [Test]
        public void Can_find_ship_at_location()
        {
            Board b = new Board();
            var position = new Position(0,0);
            b.AddShip(position,1, Orientation.Horizontal);

            Assert.IsTrue(b.IsThereAShipAt(position));
        }

        [Test]
        public void Ship_is_added_correctly()
        {
            Board b = new Board();
            var position = new Position(0,0);

            Assert.IsFalse(b.IsThereAShipAt(position));

            b.AddShip(position,1, Orientation.Horizontal);
            Assert.IsTrue(b.IsThereAShipAt(position));
        }

        [Test]
        public void Can_add_large_ships()
        {
            Board b = new Board();
            b.AddShip(new Position(0,0), 2, Orientation.Horizontal);

            Assert.IsTrue(b.IsThereAShipAt(new Position(0,0)));
            Assert.IsTrue(b.IsThereAShipAt(new Position(0,1)));
        }

        [Test]
        public void Can_add_vertical_ships()
        {
            Board b = new Board();
            b.AddShip(new Position(0, 0), 2, Orientation.Vertical);

            Assert.IsTrue(b.IsThereAShipAt(new Position(0, 0)));
            Assert.IsTrue(b.IsThereAShipAt(new Position(1, 0)));

        }
    }
}
