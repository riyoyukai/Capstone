using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// at 60
	float panHBound = 0;
	float panVBound = 0;
	
	float panHAmount = .1f;
	float panVAmount = .1f;

	// at 10
	//float panHBound = 3.7f;
	//float panVBound = 6.355f;	

	// at 35
	// float panHBound = 2.05
	// float panVBound = 3.83

	float zoomAmount = 2;
	float zoomOutMax = 60;
	float zoomInMax = 10;
	
	void Update () {
		if(Input.GetKey(KeyCode.Equals) || Input.GetKey(KeyCode.KeypadPlus)){
			print ("Zoom in");
			Zoom(-1);
		}
		else if(Input.GetKey(KeyCode.Minus) || Input.GetKey(KeyCode.KeypadMinus)){
			print ("Zoom out");
			Zoom(1);
		}

		else{
			if(Input.GetKey(KeyCode.LeftArrow)){
				print ("Pan left");
				PanH(-1);
			}
			else if(Input.GetKey(KeyCode.RightArrow)){
				print ("Pan right");
				PanH(1);
			}
			
			if(Input.GetKey(KeyCode.UpArrow)){
				print ("Pan up");
				PanV(1);
			}
			else if(Input.GetKey(KeyCode.DownArrow)){
				print ("Pan down");
				PanV(-1);
			}
		}
	}
	
	void PanH(float direction){
		Vector3 position = camera.transform.position;
		position.x += direction * panHAmount;
		camera.transform.position = position;
		PanBounds ();
	}
	
	void PanV(float direction){
		Vector3 position = camera.transform.position;
		position.y += direction * panVAmount;
		camera.transform.position = position;
		PanBounds ();
	}
	
	void Zoom(float direction){
		camera.fieldOfView += direction * zoomAmount;
		
		if(camera.fieldOfView < zoomInMax) camera.fieldOfView = zoomInMax;
		if(camera.fieldOfView > zoomOutMax) camera.fieldOfView = zoomOutMax;

		panHBound = -0.074f * camera.fieldOfView + 4.5067f;
		panVBound = -0.1271f * camera.fieldOfView + 7.63f;
		
		if(panHBound < .08f) panHBound = 0;
		if(panVBound < .005f) panVBound = 0;
		
		print ("H max: " + panHBound);
		print ("V max: " + panVBound);

		PanBounds ();
	}
	
	void PanBounds(){
		Vector3 position = camera.transform.position;
		if(position.x < -panHBound) position.x = -panHBound;
		if(position.x > panHBound) position.x = panHBound;
		if(position.y < -panVBound) position.y = -panVBound;
		if(position.y > panVBound) position.y = panVBound;
		camera.transform.position = position;
	}
}
