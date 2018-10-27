/*
* file MoveObj.cs
* @author Giovana Puccini
* @email gxp6079@rit.edu
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Method implementation for moving the object in the x, y and z dirrection by
// a given amount
public class MoveObj : MonoBehaviour {

	private Vector3 objLocation;

	// Use this for initialization
	void Start () {
			this.objLocation = transform.position;
	}

	public void moveRight(int amount){
		 objLocation.x += amount;
	}

	public void moveLeft(int amount){
			objLocation.x -= amount;
	}

	public void moveUp(int amount){
		objLocation.y += amount;
	}

	public void moveDown(int amount){
		objLocation.y -= amount;
	}

	public void moveAway(int amount){
			objLocation.z += amount;
	}

	public void moveCloser(int amount){
			objLocation.z -= amount;
	}

	// Update is called once per frame
	void Update () {
			transform.position = objLocation;
	}
}