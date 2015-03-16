using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour {
	
	float width = 0;
	float height = 0;
	Vector2 min = Vector2.zero;
	Vector2 max = Vector2.zero;

	Vector3 speed = Vector3.zero;

	void Awake(){
		width = GetComponent<CircleCollider2D> ().bounds.size.x;
		height = GetComponent<CircleCollider2D> ().bounds.size.y;
		Bounds bounds = GameObject.Find ("Boundary").GetComponent<BoxCollider2D>().bounds;
		min.x = bounds.center.x - bounds.size.x / 2 + width/2;
		min.y = bounds.center.y - bounds.size.y / 2 + height/2;
		max.x = bounds.center.x + bounds.size.x / 2 - width/2;
		max.y = bounds.center.y + bounds.size.y / 2 - height/2;
	}

	void FixedUpdate(){
		Vector3 position = transform.position;
		position.x += speed.x;
		position.y += speed.y;
	}

}
