using UnityEngine;
using System.Collections;

public class GSPlay : GameState {

	public GameObject monsterPrefab;
	MonsterController monster;

	// Use this for initialization
	void Awake () {
		// make monster based on PlayerPrefs.activemonster
		Instantiate (monsterPrefab);
		monster = GameObject.FindGameObjectWithTag ("Monster").GetComponent<MonsterController>();
	}
}
