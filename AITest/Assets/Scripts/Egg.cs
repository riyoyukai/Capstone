using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	int dependence = 0;
	int rudeness = 0;
	int politeness = 0;
	int laziness = 0;

	// politeness 1, rudeness 95
	// 2 ; 90
	// 3 ; 85
	// 4 ; 80
	// 5 ; 75
	// 10 ; 70
	// 15 ; 65
	// 20 ; 60
	// 25 ; 55
	// 30 ; 50
	// 40 ; 40

	public void IncreasePoliteness(){
		// if rudeness is less than 10, decrease by 1
		// if <= 0, = 1;
		// how to adjust politeness?
	}
	
	public void IncreaseRudeness(){
		// if politeness is less than 10, decrease by 1
		// if <= 0, = 1;
		// how to adjust rudeness?
	}
	
	public void EggAction_Ignore(){
		dependence--;
	}
		
	public void EggAction_Pet(){
		dependence++;
	}
	
	public void EggAction_Shake(){
		rudeness++;
		politeness--;
	}
	
	public void EggAction_Poke(){
		rudeness--;
		politeness++;
	}
	
	public void EggAction_Warm(){
		laziness++;
		if(laziness > 99) laziness = 99;
	}
	
	public void EggAction_Cool(){
		laziness--;
		if(laziness < 1) laziness = 1;
	}
	
	public void Hatch(){
		PlayerPrefs.monsters.Add(new Monster(dependence, rudeness, politeness, laziness));
		GameStateManager.SwitchTo ("GSPlay");
	}
}
