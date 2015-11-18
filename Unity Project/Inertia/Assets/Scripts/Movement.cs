using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	public float rotateSpeed;

	Rigidbody rigid;

// version 2 edit
	public Transform objectFollow;

	void Start ()
	{
		rigid = gameObject.GetComponent<Rigidbody> ();
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W)) {
			rigid.AddForce (transform.forward * speed * Time.deltaTime);;
		} 
		if (Input.GetKeyDown (KeyCode.S)) {
			rigid.AddForce(-transform.forward * speed * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			rigid.AddForce(transform.right * speed * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			rigid.AddForce(-transform.right * speed * Time.deltaTime);
		}


		//make this object look at the ball that is following the mouse
		//GO TO MOUSEFOLLOW TO FINISH SETUP
		transform.LookAt (objectFollow);
	}
}
