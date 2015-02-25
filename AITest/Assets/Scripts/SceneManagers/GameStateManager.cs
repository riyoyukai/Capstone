using UnityEngine;
using System.Collections;

public static class GameStateManager{

	// @gameState : the name of a level/scene
	public static void SwitchTo(string gameState){
		Application.LoadLevel (gameState);
	}
}
