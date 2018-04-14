using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject textOne, textTwo;

    private bool slowTime = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //slowTime = !slowTime;
        }

        if (slowTime) {
            Time.timeScale = 0.5f;
        } else {
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            StartCoroutine(FadeDown(2.5f, textOne.GetComponent<Text>()));
            StartCoroutine(FadeDown(2.5f, textTwo.GetComponent<Text>()));
        }
    }

    public IEnumerator FadeDown(float t, Text i) {
        i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a);
        while (i.color.a > 0.0f) {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
