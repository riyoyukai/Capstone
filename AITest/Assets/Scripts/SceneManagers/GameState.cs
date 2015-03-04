using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	float elapsedTime = 0;

	// use this to call the tick function on active monster
	public virtual void Update () {
		if(PlayerPrefs.activeMonster != null){
			elapsedTime += Time.deltaTime;
			if(elapsedTime > 1){
				elapsedTime --;
				PlayerPrefs.activeMonster.Tick ();
			}
		}
	}
}
