using System;
using SwinGameSDK;
namespace BattleShips
{
	static class GameLogic
	{
		public static void Main()
		{
			//GameState CurrentState = GameState.ViewingMainMenu;
			//Opens a new Graphics Window
			SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

			//Load Resources
			GameResources.LoadResources();

			SwinGame.PlayMusic(GameResources.GameMusic("Background"));

			//Game Loop
			do {
				GameController.HandleUserInput ();
				GameController.DrawScreen();
				//SwinGame.ProcessEvents();
			} while (!(SwinGame.WindowCloseRequested() == true | GameController.CurrentState == GameState.Quitting));

			SwinGame.StopMusic();

			//Free Resources and Close Audio, to end the program
			GameResources.FreeResources();
		}
	}
}