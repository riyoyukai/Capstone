using UnityEngine;
using System.Collections;
using System;

public class MonsterObject : MonoBehaviour {

	Behaviors state = Behaviors.Idle;	
	float behaviorTimer = 0;
	float behaviorTimerMin = 2;
	float behaviorTimerMax = 10;

	public Transform target;
	float walkspeed = 2;
	float speedY;

	CharacterController controller;
	CollisionFlags collisionFlags;
	bool facingRight = true;

	void Awake(){
		controller = GetComponent<CharacterController> ();
	}

	void OnMouseDown(){
		print ("clicked monster");
	}

	void SwitchBehavior(){
		Array values = Behaviors.GetValues(typeof(Behaviors));
		state = (Behaviors)Rand.ChooseOne (values);
		behaviorTimer = Rand.Range(behaviorTimerMin, behaviorTimerMax);
		print ("My state is: " + state.ToString () + ", Next behavior in " + behaviorTimer + " seconds");
	}
	
	void FixedUpdate () {
		behaviorTimer -= Time.deltaTime;
		if(behaviorTimer <= 0) SwitchBehavior();

		switch (state) {
		case Behaviors.Idle:

			break;

		case Behaviors.Walk:
//			transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * walkspeed);
			break;
		}




		//////
		/// 
		/// 
		/// 
		
		CalcSpeedY ();
		
		float forward = 0;
		float right = 0;
		
		// takes input and multiplies it by your current facing
		Vector3 move = forward * transform.forward + right * transform.right;
		if(move.magnitude > 1) move = move.normalized; // normalizes the vector so it's never more than 1
		
		move.y += speedY; // adds gravity
		
		collisionFlags = controller.Move(move * Time.deltaTime * walkspeed); // gets the collision flags and moves the player
	}

	void CalcSpeedY(){
		if(IsGrounded()){
			speedY = 0;
		}else{
			speedY += Config.GRAVITY * Time.deltaTime;
		}
	}

	bool IsGrounded(){
		return ((collisionFlags & CollisionFlags.CollidedBelow) > 0); // really if it's 1
	}
}
