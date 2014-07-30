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
            Ship ship = new Ship(1, new Position(0,0));
            ship.HitAt(new Position(0,0));
        }

        [Test]
        public void Hitting_near_a_ship_throws()
        {
            Ship ship = new Ship(1, new Position(0,0));
            Assert.Throws<InvalidHitPositionException>(()=>ship.HitAt(new Position(0, 1)));
        }

    }
}
