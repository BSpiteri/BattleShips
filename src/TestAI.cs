using System;
using NUnit.Framework;

namespace BattleShips
{	
	[TestFixture]
	public class TestAI
	{
		[Test]
		public void TestAIDifficulty ()
		{
			GameController.SetDifficulty (AIOption.Easy);
			GameController.StartGame ();
			Assert.IsNotInstanceOf<AIHardPlayer> (GameController.ComputerPlayer);

			Assert.IsInstanceOf<AIEasyPlayer> (GameController.ComputerPlayer);
		}
	}
}

