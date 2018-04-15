using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveWorld : MonoBehaviour {

	//public GameObject player;
	public Transform level;
    private Rigidbody otherRB;

	void start () {

	}

	void OnTriggerExit(Collider other) {
        //Upon leaving the game area reset player position and velocity plus level rotation
		other.transform.position = new Vector3(0,0,0);
		level.transform.rotation =  Quaternion.identity;
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
