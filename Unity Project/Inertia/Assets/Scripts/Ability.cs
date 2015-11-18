using UnityEngine;
using System.Collections;

public class Ability : MonoBehaviour {

	public GameObject shieldWall;
	public int spawnDstance;
	float timer;
	bool active = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (1) && active == true) 
		{
			Instantiate (shieldWall, transform.position + (transform.forward * spawnDstance), transform.rotation);
			active = false;
		}
		if (active == false) 
		{
			timer += Time.deltaTime;
		}
		if (timer >= 10) 
		{
			active = true;
			timer = 0;
		}
	}
	void OnGUI()
	{
		GUI.Label (new Rect (170, 100, 50, 50), timer.ToString());
	}
}