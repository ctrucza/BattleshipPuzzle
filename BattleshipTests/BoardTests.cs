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
            b.AddShip(new Position(0,0), new Ship(1, new Position(0,0)), Orientation.Horizontal);
        }

        [Test]
        public void Can_find_ship_at_location()
        {
            Board b = new Board();
            var position = new Position(0,0);
            b.AddShip(position, new Ship(1, position), Orientation.Horizontal);

            Assert.IsNotNull(b.GetShipAt(position));
        }

        [Test]
        public void Ship_is_added_correctly()
        {
            Board b = new Board();
            var position = new Position(0,0);

            Assert.IsNull(b.GetShipAt(position));

            b.AddShip(position, new Ship(1, position), Orientation.Horizontal);
            Assert.IsNotNull(b.GetShipAt(position));
        }

        [Test]
        public void Can_add_large_ships()
        {
            Board b = new Board();
            b.AddShip(new Position(0,0), new Ship(2, new Position(0,0)),  Orientation.Horizontal);

            Assert.IsNotNull(b.GetShipAt(new Position(0,0)));
            Assert.IsNotNull(b.GetShipAt(new Position(0,1)));
        }

        [Test]
        public void Can_add_vertical_ships()
        {
            Board b = new Board();
            b.AddShip(new Position(0, 0), new Ship(2, new Position(0,0), Orientation.Vertical), Orientation.Vertical);

            Assert.IsNotNull(b.GetShipAt(new Position(0, 0)));
            Assert.IsNotNull(b.GetShipAt(new Position(1, 0)));
        }

        [Test]
        public void Can_retrieve_ships()
        {
            Board b = new Board();
            var position = new Position(0,0);

            Assert.IsNull(b.GetShipAt(position));

            b.AddShip(position, new Ship(1, position), Orientation.Horizontal );
            Ship ship = b.GetShipAt(position);

            Assert.IsNotNull(ship);

        }
    }
}
