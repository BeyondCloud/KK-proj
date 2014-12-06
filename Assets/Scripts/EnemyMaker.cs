using UnityEngine;
using System.Collections;

public class EnemyMaker : MonoBehaviour {

	public GameObject enemy;
	public Transform spawnTop;
	public Transform spawnButton;
	public Transform spawnX;


	public float spawnTime = 1.0f;
	void Start () {
		InvokeRepeating ("MakeEnemy", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void MakeEnemy()
	{

		Vector3 enemyPos = new Vector3(spawnX.position.x , Random.Range(spawnTop.position.y, spawnButton.position.y) , 0);
		Instantiate (enemy, enemyPos ,transform.rotation);



	}

}
