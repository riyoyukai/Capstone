using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {
	// game a gamestate monobehavior
	// specific states inherit from gamestate
	// every update, call Tick from static monster reference
	// check how large time can be stored in floats for storing time until next care need
	/*
	 * Gamestate adds up deltatime and every time its >= 1
	 * monster tickers get decreased by 1 second
	 * then subtract 1 from the gamestate ticker
	 * 
	 * for inventory, reference pluckin pairs
	 * when you drag an icon, move it from inventory
	 * if mouse released in play area, give it different behavior
	 * if i do multiple uses, every time you use it, reduce use count by 1, if 0 then remove from array
	 * 
	 * monster "is in egg form" = true
	 * when hatches, change its artwork
	 * 
	 * alternately, have an egg class, and when it hatches, call new Monster()
	 * pass the values of the egg class into the new monster
	 * 
	 * monster prefab that is generic and depending on what monster you pick,
	 * it loads artwork and decides behavior timers and stuff
	 * 
	 * For inventory movement
	 * drag button/image UI component, if it's off the inventory area,
	 * raycast and instantiate gameobject where your mouse is
	 * 
	 * 
	 */

}
