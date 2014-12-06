using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {



	public Transform enemyPosition;
	public float moveSpeed = 0.03f;
	public Transform enemyDestroyPoint;

	void Update () {
		enemyPosition.position  = new Vector2(enemyPosition.position.x + moveSpeed ,enemyPosition.position.y);

		if(this.transform.position.x > enemyDestroyPoint.position.x)
			Destroy(gameObject);

	}


}
