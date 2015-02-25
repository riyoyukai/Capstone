using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	Monster monsterInEgg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void EggAction_Ignore(){
		monsterInEgg.dependence--;
	}
	
	public void EggAction_Shake(){
		monsterInEgg.rudeness++;
		monsterInEgg.politeness--;
	}
	
	public void EggAction_Poke(){
		monsterInEgg.rudeness--;
		monsterInEgg.politeness++;
	}


	public void EggAction_Pet(){
		monsterInEgg.dependence++;
	}
	
	public void EggAction_Warm(){
		monsterInEgg.laziness++;
	}
	
	public void EggAction_Cool(){
		monsterInEgg.laziness--;
	}
	
	public void Hatch(){
		PlayerPrefs.monsters.Add(new Monster());
	}
}
