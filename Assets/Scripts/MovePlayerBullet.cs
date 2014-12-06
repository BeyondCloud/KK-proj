using UnityEngine;
using System.Collections;

public class MovePlayerBullet : MonoBehaviour {



	public Transform playerPosition;
	public Transform firePosition;

	public GameObject bullet;

	public float moveSpeed  = 10.0f;


	private Vector2 beforeNormalized ;

	private Vector2 playerToMouse ;
	private Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	private SpriteRenderer spriteRenderer;

	// Update is called once per frame
	void Start()
	{

		spriteRenderer = GetComponent<SpriteRenderer> ();
		playerToMouse = (mouseWorldPoint- playerPosition.position);   //Vecto
	}
	void Update () {

	

		firePosition.position= new  Vector2((firePosition.position.x + playerToMouse.x  * Time.deltaTime),
		                                    firePosition.position.y + (playerToMouse.y  * Time.deltaTime));


		

		if(Mathf.Abs(this.transform.position.x)>3 || Mathf.Abs(this.transform.position.y)>3)
		  	Destroy(gameObject);


	}

}
