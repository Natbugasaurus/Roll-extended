using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Transform target;

	private Vector3 offset;

	void Start () {
        //Set camera offset from player position
		offset = transform.position - target.transform.position;
	}
		
	void Update () {
        //Camera tracks player position
		transform.position = Vector3.Lerp(transform.position, offset + target.transform.position, 1f);

        //Camera always looks at player
		transform.LookAt(target);
	}
}
