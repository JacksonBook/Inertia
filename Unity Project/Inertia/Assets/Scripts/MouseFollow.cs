using UnityEngine;
using System.Collections;

public class MouseFollow : MonoBehaviour {
	//place this on the object that you want the ship to follow (GO TO MOVEMENT TO FINSIH SETUP)



	//gets the mouse position
	Vector3 mousePos;

	//this is the distance of the invisible object from the camera
	//only public for edit
	public float disFromCam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePos.x = Input.mousePosition.x;
		mousePos.y = Input.mousePosition.y;



		mousePos.z = disFromCam;

		this.transform.position = Camera.main.ScreenToWorldPoint (mousePos);
		
	}
}
