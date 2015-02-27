using UnityEngine;
using System.Collections;

public class InventoryController : MonoBehaviour {

	public Transform[] spots;

	public void Awake(){
		/* // for testing purposes
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		PlayerPrefs.inventory.Add(new Item());
		*/
	}

	public void OpenInventory(){
		this.enabled = !this.enabled;
		this.gameObject.SetActive(this.enabled);
	}

	public void PreviousPage(){

	}

	public void NextPage(){

	}
}
