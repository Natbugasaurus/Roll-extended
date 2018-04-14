using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
    public AudioSource soundSource;
    public AudioClip clink;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update () {

    }

	void OnCollisionEnter(Collision collision) {
        soundSource.PlayOneShot(clink, 1f);
	}
}
