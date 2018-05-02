using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour {
	public GameObject exp;
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Bomb") {
			Destroy (col.gameObject);
			Destroy(Instantiate (exp, col.gameObject.transform.position, col.gameObject.transform.rotation),2);
		}
	}
}
