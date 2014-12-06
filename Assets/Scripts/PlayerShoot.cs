using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	public Transform playerPosition;
	public GameObject bullet;
	public float timeBetweenBullets = 0.19f;
	float timer;
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;

	}




	public void FixedUpdate () {

	
		if(Input.GetButton ("Fire1") )
		{
			Shoot ();
		}
		
		
		
	}
	public void Shoot ()
	{
				if (timer < timeBetweenBullets)
					return;
		timer = 0f;

		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector3 playerPos = playerPosition.position;
		Vector2 playerToMouse = mouseWorldPoint- playerPosition.position;
		Instantiate (bullet, playerPos,transform.rotation);
		
		
	}

}
