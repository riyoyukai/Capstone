using UnityEngine;
using System.Collections;

public enum Diet{
	Plants, Insects, Fish, Meat, Any
}

public enum Circadian{
	Diurnal, Nocturnal, Matutinal, Vespertine, Crepuscular
}

public class Monster{

	MonsterController monsterObject;

	public Circadian circadian;
	public int rudeness;
	public int politeness;
	public int laziness;
	public int dependence;
	public int metabolism; // 1 to 9; 9 is 3x a day, 1 is 1x every 3days
	public Diet diet;

	
	public int happinessTier;
	public int positiveInteractions;

	public bool sick = false;

	public bool hungry = false;
	public int hunger = 100;
	private float hungerTicker = 0;
	private float hungerTickerMax = 1 * Config.DAYS;

	public bool lonely = false;
	public int comfort = 100;
	private float comfortTicker = 0;
	private float comfortTickerMax = 8 * Config.HOURS;

	public bool sleepy = false;
	public int sleepiness = 100;
	private float sleepinessTicker = 0;
	private float sleepinessTickerMax = 16 * Config.HOURS;

	public bool bored = false;
	public int fun = 100;
	private float funTicker = 0;
	private float funTickerMax = 4 * Config.HOURS;

	public Monster(int dependence, int rudeness, int politeness, int laziness){
		this.dependence = dependence;
		this.rudeness = rudeness;
		this.politeness = politeness;
		this.laziness = laziness;
	}

	public void Tick(){

		hungerTicker--;
		if(hungerTicker <= 0) TickHunger();

		comfortTicker --;
		sleepinessTicker --;
		funTicker --;
	}
	
	private void TickHunger(){
		if(!hungry){
			hungerTicker = hungerTickerMax/2; // reasonable care time
			hungry = true;
			// alert hungry
		}else{ 
			// missed window of good care time
		}
	}
		
	private void TickComfort(){
		comfortTicker = comfortTickerMax;
	}
	
	
	
	private void TickSleepiness(){
		sleepinessTicker = sleepinessTickerMax;
	}
	
	
	
	private void TickFun(){
		funTicker = funTickerMax;
	}
	

}
