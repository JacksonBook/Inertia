using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	 int bullets;
	//timer/Cool down timer
	 float timer;
	public float bulletSpeed;

	public Rigidbody bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (bullets == 1) {
			if(Input.GetKeyDown(KeyCode.Mouse0)){
				Rigidbody clone;
				clone = Instantiate(bulletPrefab, transform.position, transform.rotation)as Rigidbody;
				clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);
				bullets --;
			}
		}

		if (bullets == 0) {
			//timer = 0;
			timer += Time.deltaTime;
		}
		if (timer >= 5) {
			bullets = bullets + 1;
			timer = 0;
		}
	}

	void OnGUI()
	{
		GUI.Label (new Rect (100, 100, 50, 50), timer.ToString());
		//GUI.Label (new Rect (170, 100, 50, 50), bullets.ToString());
	}
}
