using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAmount : MonoBehaviour {
	public static int scoreAmount = 0;
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
			scoreAmount += 10;
		}
	}
}
