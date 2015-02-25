﻿using UnityEngine;
using System.Collections;

public static class Config{
	public static float GRAVITY = -5;
	
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