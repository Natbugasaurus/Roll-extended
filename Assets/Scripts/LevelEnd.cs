using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour {
    public GameObject player;
    public Text winText;
    public AudioSource soundSource;
    public AudioClip winSound;

    private bool win = false;

	void OnTriggerEnter(Collider other) {
        //When player reaches end gate
		if (other.gameObject.tag == "Player") {
            //Change win bool for text
            win = true;
            //Play streamer win sound
            soundSource.PlayOneShot(winSound, 1f);
        }
	}

    private void Update() {
        //Set win back to false if player starts playing again
        if (Input.GetKeyDown(KeyCode.W) && win) {
            win = false;
        }

        //If win is true display win text
        if (win) {
            winText.color = new Color(winText.color.r, winText.color.g, winText.color.b, 1f);
            
        } else {
            winText.color = new Color(winText.color.r, winText.color.g, winText.color.b, 0f);
        }
    }
}
