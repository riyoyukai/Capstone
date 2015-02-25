using UnityEngine;
using System.Collections;

// i guess this is more like the gamestatemanager maybe
public class NavigationManager : MonoBehaviour {

	/*private static NavigationManager _instance;
	public static NavigationManager instance{
		get{
			if(_instance == null) _instance = GameObject.FindObjectOfType<NavigationManager>();
			DontDestroyOnLoad(_instance.gameObject);
			return _instance;
		}
	}

	void Awake(){
		if(_instance == null){
			_instance = this;
			DontDestroyOnLoad(this);
		}else{
			if(this != _instance) Destroy(this.gameObject);
		}
	}*/

	public static void SwitchTo(string gameState){
		print (gameState);
		switch(gameState.ToLower()){
			case "play":
			Application.LoadLevel("GSPlay");
			break;

			case "title":

			break;

			case "options":

			break;

			case "credits":

			break;

			case "petselect":

			break;

			case "nursery":

			break;

			case "petprofile":

			break;

			case "hub":

			break;

			case "explore":

			break;

			case "battle":

			break;
		}
	}
}
