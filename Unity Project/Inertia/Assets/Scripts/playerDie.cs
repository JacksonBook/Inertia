using UnityEngine;
using System.Collections;

public class playerDie : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Hazard") 
		{
			Destroy(gameObject);
		}
	}
}
