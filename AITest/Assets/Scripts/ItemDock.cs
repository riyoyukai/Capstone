using UnityEngine;
using System.Collections;

public class ItemDock : MonoBehaviour {
	
	private float halfW, halfH;

	void Start () {
		halfW = GetComponent<RectTransform> ().rect.width/2;
		halfH = GetComponent<RectTransform> ().rect.height/2;
	}
	
	public void ReceiveItem(GameObject item){
		item.transform.position = this.transform.position;
	}
	
	public void TakeItem(){
		
	}
	
	public bool IsPointWithinBounds(Vector2 p){
		if (p.x > transform.position.x - halfW &&
		    p.x < transform.position.x + halfW &&
		    p.y > transform.position.y - halfH &&
		    p.y < transform.position.y + halfH) {
			return true;
		}
		
		return false;
	}
}
