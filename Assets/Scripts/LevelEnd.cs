using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour {
	//public Transform level;
	//public GameController gameController;

	void start () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
            Debug.Log("WIN!");
		}
	}
}
