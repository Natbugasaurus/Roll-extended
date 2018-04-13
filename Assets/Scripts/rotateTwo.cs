using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(transform.position, this.transform.forward, 30 * Time.deltaTime);
    }
}
