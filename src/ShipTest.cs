using NUnit.Framework;
using SwinGameSDK;
using System;
namespace BattleShips
{
	[TestFixture ()]
	public class NUnitTestClass
	{
		[Test ()]
		public void TestCase ()
		{
			var newShip = new Ship (ShipName.None);
			Assert.AreEqual (newShip.Name, "None");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);

			newShip = new Ship (ShipName.Tug);
			Assert.AreEqual (newShip.Name, "Tug");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);

			newShip = new Ship (ShipName.Submarine);
			Assert.AreEqual (newShip.Name, "Submarine");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);

			newShip = new Ship (ShipName.Destroyer);
			Assert.AreEqual (newShip.Name, "Destroyer");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);

			newShip = new Ship (ShipName.Battleship);
			Assert.AreEqual (newShip.Name, "Battleship");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);

			newShip = new Ship (ShipName.AircraftCarrier);
			Assert.AreEqual (newShip.Name, "Aircraft Carrier");
			newShip.Hit ();
			Assert.AreEqual (newShip.Hits, 1);
		}
	}
}