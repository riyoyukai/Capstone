using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryController : MonoBehaviour {

	public Transform[] spots;
	int page = 0;

	void Awake(){
		 // for testing purposes
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("food"));
	}

	void Start(){
		for(int i = 0; i < PlayerPrefs.inventory.Count; i++){
			for(int j = 0; j < Config.items.Length; j++){
				if(PlayerPrefs.inventory[i].itemName == Config.items[j].name){
					print ("MATCH: " + PlayerPrefs.inventory[i].itemName);
					//TODO: set button text as item name
					//TODO: set image sprite to sprite
				}
			}
		}
	}

	public void OpenInventory(){
		this.gameObject.SetActive(!this.gameObject.activeSelf);
	}

	public void PreviousPage(){

	}

	public void NextPage(){

	}
}
