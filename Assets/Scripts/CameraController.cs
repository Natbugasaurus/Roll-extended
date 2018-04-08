﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public Transform target;
    public float rotateSpeed;

	float x = 0.0f;
	float y = 0.0f;

	public float yMin, yMax;

	private Vector3 offset;

	void Start () {
		offset = transform.position - target.transform.position;
	}
		
	void Update () { 
        /*
		x += Input.GetAxis ("Mouse X") * rotateSpeed;

		if (invertY) {
			y += Input.GetAxis ("Mouse Y") * rotateSpeed;
		} else {
			y -= Input.GetAxis ("Mouse Y") * rotateSpeed;
		}
        */
		y = Mathf.Clamp (y, yMin, yMax);

		Quaternion rotation = Quaternion.Euler (y, x, 0);
		transform.rotation = rotation;

		transform.position = Vector3.Lerp(transform.position, rotation * offset + target.transform.position, 0.08f);
		transform.LookAt(target);
	}
}
