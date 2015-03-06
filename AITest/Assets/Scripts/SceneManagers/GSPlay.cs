using UnityEngine;
using System.Collections;

public class GSPlay : GameState {

	public GameObject monsterPrefab;
	MonsterController monster;
	public GameObject navPanel;

	// Use this for initialization
	void Awake () {
		// make monster based on PlayerPrefs.activemonster
		Instantiate (monsterPrefab);
		monster = GameObject.FindGameObjectWithTag ("Monster").GetComponent<MonsterController>();
		if(Config.items == null) Config.LoadItemImages ();
	}

	void Start(){
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
