using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour {
    public GameObject player;
    public Text winText;
    public ParticleSystem winParticle;
    public AudioSource soundSource;
    public AudioClip winSound;

    private bool win = false;

	void start () {

	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
            win = true;
            soundSource.PlayOneShot(winSound, 1f);
            winParticle.Emit(1000);
        }
	}

    private void Update() {
        if (Input.GetKeyDown(KeyCode.W) && win) {
            win = false;
        }

        if (win) {
            winText.color = new Color(winText.color.r, winText.color.g, winText.color.b, 1f);
            
        } else {
            winText.color = new Color(winText.color.r, winText.color.g, winText.color.b, 0f);
        }
    }
}
