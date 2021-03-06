﻿using NUnit.Framework;
using Battleship;

namespace BattleshipTests
{
    [TestFixture]
    public class BoardTests
    {
        [Test]
        public void Test_usage()
        {
            var b = new Board();
            b.AddShip(new Ship(1, new Position(0,0), Orientation.Horizontal));
        }

        [Test]
        public void Can_find_ship_at_location()
        {
            var b = new Board();
            var position = new Position(0,0);
            b.AddShip(new Ship(1, position, Orientation.Horizontal));

            Assert.IsNotNull(b.GetShipAt(position));
        }

        [Test]
        public void Ship_is_added_correctly()
        {
            var b = new Board();
            var position = new Position(0,0);

            Assert.IsNull(b.GetShipAt(position));

            b.AddShip(new Ship(1, position, Orientation.Horizontal));
            Assert.IsNotNull(b.GetShipAt(position));
        }

        [Test]
        public void Can_add_large_ships()
        {
            var b = new Board();
            b.AddShip(new Ship(2, new Position(0,0), Orientation.Horizontal));

            Assert.IsNotNull(b.GetShipAt(new Position(0,0)));
            Assert.IsNotNull(b.GetShipAt(new Position(0,1)));
        }

        [Test]
        public void Can_add_vertical_ships()
        {
            var b = new Board();
            b.AddShip(new Ship(2, new Position(0,0), Orientation.Vertical));

            Assert.IsNotNull(b.GetShipAt(new Position(0, 0)));
            Assert.IsNotNull(b.GetShipAt(new Position(1, 0)));
        }

        [Test]
        public void Can_retrieve_ships()
        {
            var b = new Board();
            var position = new Position(0,0);

            Assert.IsNull(b.GetShipAt(position));

            b.AddShip(new Ship(1, position, Orientation.Horizontal) );
            Ship ship = b.GetShipAt(position);

            Assert.IsNotNull(ship);
        }

        [Test]
        public void Cannot_add_ship_outside_the_board()
        {
            var b = new Board();

            var ship = new Ship(1, new Position(0,10), Orientation.Horizontal);
            Assert.Throws<InvalidShipException>(()=>b.AddShip(ship));
        }

        [Test]
        public void Cannot_add_overlapping_ships()
        {
            var b = new Board();

            var ship = new Ship(1, new Position(0, 0), Orientation.Horizontal);
            b.AddShip(ship);
            Assert.Throws<InvalidShipException>(() => b.AddShip(ship));
        }

    }
}
