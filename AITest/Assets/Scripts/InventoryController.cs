using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour {
	public GameObject ball1;
	public GameObject ball2;
	public GameObject ball3;
	public GameObject ball4;


	public RectTransform outsideInventory;
	public Vector2 playAreaMin;
	public Vector2 playAreaMax;
	public Image[] spots;
	int page = 1;

	void Awake(){
		// for testing purposes
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("ball"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));
		PlayerPrefs.inventory.Add(new Item("food"));

		// get the valid outside inventory area
		float width = outsideInventory.rect.width;
		float height = outsideInventory.rect.height;
		playAreaMin = new Vector2 (outsideInventory.transform.position.x - width/2, outsideInventory.transform.position.y + height/2);
		playAreaMax = new Vector2 (outsideInventory.transform.position.x + width/2, outsideInventory.transform.position.y - height/2);
	}

	void Start(){
		LoadPage ();
	}

	public void OpenInventory(){
		this.gameObject.SetActive(!this.gameObject.activeSelf);
	}

	public void PreviousPage(){
		page--;
		if(page < 1){
			//TODO: figure out what your last page should be. inventory % spots length?
			page = PlayerPrefs.inventory.Count / spots.Length;
		}
		LoadPage ();
	}

	public void NextPage(){
		page++;
		if(page > PlayerPrefs.inventory.Count / spots.Length){
			page = 1;
		}
		LoadPage ();
	}

	public void LoadPage(){
		for(int i = 0; i < spots.Length; i++){
			for(int j = 0; j < Config.items.Length; j++){
				int ii = i + (spots.Length * (page-1));
				if(PlayerPrefs.inventory[ii].itemName == Config.items[j].name){
					spots[i].sprite = Config.items[j];
					spots[i].gameObject.GetComponentInChildren<Text>().text = Config.items[j].name;
					continue;
				}
			}
		}
	}
	
	public void E_DownOnIcon(GameObject icon){
		
	}
	
	public void E_DragIcon(GameObject icon){
		icon.transform.position = Input.mousePosition;
		if(icon.transform.position.x > playAreaMin.x && icon.transform.position.x < playAreaMax.x &&
		   icon.transform.position.y < playAreaMin.y && icon.transform.position.y > playAreaMax.y){
			print ("Within area");
			//TODO: figure out how to store a reference to which item (in playerprefs) it is
			// from the icon
			// set that item's inInventory value to false
		}
	}
	
	public void E_UpOnIcon(GameObject icon){
		if(icon.transform.position.x > playAreaMin.x && icon.transform.position.x < playAreaMax.x &&
		   icon.transform.position.y < playAreaMin.y && icon.transform.position.y > playAreaMax.y){

		}
	}
}
