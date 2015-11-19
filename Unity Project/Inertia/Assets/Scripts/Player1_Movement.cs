using UnityEngine;
using System.Collections;

public class Player1_Movement : MonoBehaviour {
	
	public float speed;
	public float rotateSpeed;
	
	Rigidbody rigid;
	
	void Start ()
	{
		rigid = gameObject.GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//Left Joystick
		
		if (Input.GetAxis ("Vertical")>0) {
			rigid.AddForce (Vector3.forward * speed * Time.deltaTime);
		} 
		if (Input.GetAxis ("Vertical")<0) {
			rigid.AddForce(-Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetAxis ("Horizontal")>0) {
			rigid.AddForce(Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetAxis ("Horizontal")<0) {
			rigid.AddForce(-Vector3.right * speed * Time.deltaTime);
		}


		//Right Joystick
		//rotate right
		if (Input.GetAxis ("Horizontal_RightStick_Player1")>0) {
			transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		}
		//rotate left
		if (Input.GetAxis ("Horizontal_RightStick_Player1")<0) {
			transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);
		}
		
		

	}
}
