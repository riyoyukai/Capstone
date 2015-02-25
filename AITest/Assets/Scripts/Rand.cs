using UnityEngine;
using System.Collections;

public static class Rand {
	
	public static float Range(float min, float max){
		return Random.Range(min, max);
	}
	
	public static int RangeInt(int min, int max){
		System.Random r = new System.Random ();
		return (int)(Mathf.Floor((float)r.NextDouble() * (max - min + 1)) + min);
	}

	public static object ChooseOne(System.Array choices){
		if(choices.Length == 0) return null;
		return choices.GetValue(Rand.RangeInt (0, choices.Length-1));
	}
}
