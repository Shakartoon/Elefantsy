using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public Transform movingPlatform; 
	public Transform position1; 
	public Transform position2; 
	public Vector3 newPosition; 
	public string currentState; 
	public float smooth; //determines how long it takes to move platform from one position to another 
	public float resetTime; //when it needs to reset and move to a new position 

	void Start () {
		ChangeTarget (); 
	}
	
	void FixedUpdate () { // allows code to run at a consistent intervial 

		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime); 
	}

	void ChangeTarget() { // runs every time we need to reset it 

		if (currentState == "Moving To Position 1") {
			currentState = "Moving To Position 2"; 
			newPosition = position2.position; 
		}

		else if (currentState == "Moving To Position 2") {
			currentState = "Moving To Position 1"; 
			newPosition = position1.position; 

		}

		else if (currentState == " ") {
			currentState = "Moving To Position 2"; 
			newPosition = position2.position; 
	
		}

		Invoke ("ChangeTarget", resetTime);  
	}
}
