using Battleship;
using NUnit.Framework;

namespace BattleshipTests
{
    [TestFixture]
    public class ShipTests
    {
        [Test]
        public void Ship_can_be_hit()
        {
            Ship ship = new Ship(1, new Position(0,0), Orientation.Horizontal);
            ship.HitAt(new Position(0,0));
        }

        [Test]
        public void Hitting_near_a_ship_throws()
        {
            Ship ship = new Ship(1, new Position(0,0), Orientation.Horizontal);
            Assert.Throws<InvalidHitPositionException>(()=>ship.HitAt(new Position(0, 1)));
        }

        [Test]
        public void Hitting_all_holes_sinks_the_ship()
        {
            Ship ship = new Ship(2, new Position(0,0), Orientation.Horizontal);
            ship.HitAt(new Position(0,0));
            Assert.IsFalse(ship.IsSunken());
            ship.HitAt(new Position(0,1));
            Assert.IsTrue(ship.IsSunken());
        }

    }
}
