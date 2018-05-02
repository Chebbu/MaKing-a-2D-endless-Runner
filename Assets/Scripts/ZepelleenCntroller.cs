using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 namespace  mygame {

public class ZepelleenCntroller : MonoBehaviour {
	float FlyForce =40.0f;
	public int score;
		public GameObject bomb ;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		bool jetpackActive = Input.GetButton ("Fire1");
		if (jetpackActive) {

			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (2f, FlyForce));
		}

		Vector2 newVelocity = GetComponent<Rigidbody2D>().velocity;
		newVelocity.x = 2f;
		GetComponent<Rigidbody2D>().velocity = newVelocity;
			if (Input.GetButtonDown ("Fire2")) {
				Instantiate (bomb, transform.position, transform.rotation);
			}

	}
}
}