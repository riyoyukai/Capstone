using UnityEngine;
using System.IO;
using System.Collections;

public static class Config{

	public static Sprite[] LoadItemImages(){
		// TODO: loads all item images and returns to be stored nonstatically in whichever gamestate, called in awake
		string folder = Directory.GetCurrentDirectory() + @"\Assets\Resources\Items\";
		string[] files = Directory.GetFiles (folder, "*.jpg");
		Sprite[] sprites = new Sprite[files.Length];
		for(int i = 0; i < files.Length; i++){
			
			files[i] = Path.GetFileName(files[i]).Split('.')[0];
			Debug.Log ("File: " + files[i]);
			Sprite sp = Resources.Load<Sprite>("Items/" + files[i]);
			Debug.Log(sp/*sprites[i]*/);
		}
		return sprites;
	}

	public static float GRAVITY = -5;

	public static int DAYS = 24 * 60 * 60; // 1 day in seconds
	public static int HOURS = 60 * 60; // 1 hour in seconds
	
	public static Vector3 Pos2to3(Vector2 v2, Vector3 v3){
		v3.x = v2.x;
		v3.y = v2.y;
		return v3;
	}
	
	public static Vector2 Pos3to2(Vector2 v3){
		return new Vector2(v3.x, v3.y);
	}

	// see if two points are close enough to each other. does not use Z
	public static bool CloseEnough(Vector3 one, Vector3 two, float minDistance){
		float dx = one.x - two.x;
		float dy = one.y - two.y;

		if(dx*dx + dy*dy < minDistance * minDistance) return true;
		return false;
	}
}
