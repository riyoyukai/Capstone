using UnityEngine;
using System.Collections;

public static class StaticGSM{

	// @gameState : the name of a level/scene
	public static void SwitchTo(string gameState){
		Application.LoadLevel (gameState);
	}
}

public class GameStateManager : MonoBehaviour {
	
	public void SwitchTo(string gameState){
		print (gameState);
		StaticGSM.SwitchTo (gameState);
	}
}
