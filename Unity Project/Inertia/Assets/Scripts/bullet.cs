using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {


	// public GameObject engineRight;
	// engineRight.GetComponent()<animation>.Play("Right");
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{
		//if bullet hits player
		if (other.gameObject.tag == "Player") {
			Destroy(other.gameObject);
		}
		Destroy(gameObject);
	}

}
