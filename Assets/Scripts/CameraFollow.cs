using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject targetobject ;
	private float distanceToTarget;
	// Use this for initialization
	void Start () {
		distanceToTarget = transform.position.x - targetobject.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		float targetobjectx =targetobject.transform.position.x ;


		Vector3 newCamerapostion = transform.position ;
		newCamerapostion.x = targetobjectx + distanceToTarget;
		transform.position = newCamerapostion ;
	}
}
