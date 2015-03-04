using UnityEngine;
using System.Collections;

public class GSPlay : GameState {

	public GameObject monsterPrefab;
	MonsterController monster;
	public GameObject navPanel;
	Sprite[] items;

	// Use this for initialization
	void Awake () {
		// make monster based on PlayerPrefs.activemonster
		Instantiate (monsterPrefab);
		monster = GameObject.FindGameObjectWithTag ("Monster").GetComponent<MonsterController>();
	}

	void Start(){
		items = Config.LoadItemImages ();
	}

	public void ToggleNav(){
		navPanel.SetActive(!navPanel.activeSelf);
		print ("Toggling navigation");
	}

	public override void Update(){
		base.Update();

		// do stuff

	}
}
