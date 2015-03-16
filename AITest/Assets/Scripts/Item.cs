using UnityEngine;
using System.Collections;

public enum ItemType{
	Ball, Food
}

public class Item {

	public string itemName = "";
	bool edible = false;
	int usesleft = 1;
	int maxuses = 1;
	public bool inInventory = true;

	public Item(string name){
		itemName = name;
	}
}
