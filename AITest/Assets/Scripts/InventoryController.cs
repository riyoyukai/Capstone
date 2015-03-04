using UnityEngine;
using System.Collections;

public class InventoryController : MonoBehaviour {

	public Transform[] spots;

	public void Awake(){
		 // for testing purposes
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("food"));
	}

	public void OpenInventory(){
		this.gameObject.SetActive(!this.gameObject.activeSelf);
		print ("Toggling inventory");
	}

	public void PreviousPage(){

	}

	public void NextPage(){

	}
}
