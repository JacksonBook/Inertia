using UnityEngine;
using System.Collections;

public class shieldWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Destroy(gameObject);
		}
		if (other.gameObject.tag == "Bullet") 
		{
			Destroy(gameObject);
		}
	}
}
