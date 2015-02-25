using UnityEngine;
using System.Collections;
using System;

public enum Behaviors{
	Walk, Idle/*, Sleep, Eat, Poop, PlaytargetBall, PlaySwing, GoToSwing, Cuddle, TakeItem, Rude, Polite*/
}

public class MonsterController : MonoBehaviour {
	public GameObject targetBall;
	Monster monster = new Monster ();

	float width = 0;
	float height = 0;
	Vector2 min = Vector2.zero;
	Vector2 max = Vector2.zero;

	Behaviors state = Behaviors.Idle;	
	float behaviorTimer = 1;
	float behaviorTimerMin = 1;
	float behaviorTimerMax = 2;

	bool beingPet = false;
	bool mouseDown = false;
	
	float walkspeed = 1;
	
	Vector3 target = Vector3.zero;

	Vector3 direction = Vector3.zero;
	Vector3 stationary = Vector3.zero;
	Vector3 left = new Vector3 (-1, 0, 0);
	Vector3 right = new Vector3 (1, 0, 0);
	Vector3 up = new Vector3 (0, 1, 0);
	Vector3 down = new Vector3 (0, -1, 0);
	
	void Awake(){
		PlayerPrefs.activeMonster = monster;

		width = GetComponent<BoxCollider2D> ().bounds.size.x;
		height = GetComponent<BoxCollider2D> ().bounds.size.y;
		Bounds bounds = GameObject.Find ("Boundary").GetComponent<BoxCollider2D>().bounds;
		min.x = bounds.center.x - bounds.size.x / 2 + width/2;
		min.y = bounds.center.y - bounds.size.y / 2 + height/2;
		max.x = bounds.center.x + bounds.size.x / 2 - width/2;
		max.y = bounds.center.y + bounds.size.y / 2 - height/2;
	}

	void FixedUpdate () {

		behaviorTimer -= Time.deltaTime;
		if(behaviorTimer <= 0){
			NewBehavior();
		}

		DoBehavior ();

		/* testing purposes only
		if(Input.GetKey(KeyCode.W)) direction = up;
		if(Input.GetKey(KeyCode.A)) direction = left;
		if(Input.GetKey(KeyCode.S)) direction = down;
		if(Input.GetKey(KeyCode.D)) direction = right;*/
		
		Vector3 move = direction * walkspeed; // new movement to add to position
		Vector3 position = transform.position; // temp position var
		position += move * Time.deltaTime; // add new movement * deltaTime
		transform.position = position;
	}

	void DoBehavior(){
		switch(state){
		case Behaviors.Walk:
			if(Config.CloseEnough(transform.position, target, .3f)){
				direction = stationary;
				target.x = transform.position.x;
				// generate new target until behaviortimer is 0
			}
			break;
		}
	}
	
	void NewBehavior(){
		Array values = Behaviors.GetValues(typeof(Behaviors));
		state = (Behaviors)Rand.ChooseOne (values);
		behaviorTimer = Rand.Range(behaviorTimerMin, behaviorTimerMax);
		print ("My state is: " + state.ToString () + ", Next behavior in " + behaviorTimer + " seconds");
		
		StartBehavior();
	}
	
	void StartBehavior(){
		switch(state){
		case Behaviors.Idle:
			direction = stationary;
			break;
			
		case Behaviors.Walk:
			NewMoveTarget();
			break;
		}
	}

	void NewMoveTarget(){
		target.x = Rand.Range (min.x, max.x);

		target.y = transform.position.y;
		Vector3 targetBallPosition = targetBall.transform.position;
		targetBallPosition.x = target.x;
		targetBallPosition.y = target.y;
		targetBall.transform.position = targetBallPosition;

		if(transform.position.x < target.x) direction = right;
		else direction = left;
	}
	
	void OnMouseDown(){
		beingPet = true;
	}
	
	// probably take this out because otherwise it would interfere with camera movement
	void OnMouseEnter(){
		if(mouseDown){
			beingPet = true;
		}
	}
	
	void OnMouseExit(){
		beingPet = false;
	}
	
	void Update() {
		if (Input.GetMouseButton(0)) mouseDown = true;
		else{
			beingPet = false;
			mouseDown = false;
		}
		
		//if(beingPet) print("BEING PET");
		//else print ("not being pet anymore");
	}
}
