using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOne : MonoBehaviour {

    private bool clockWise;

	// Use this for initialization
	void Start () {
        clockWise = true;
        Debug.Log(this.transform.rotation.eulerAngles.z.ToString());
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.rotation.eulerAngles.z > 350 && this.transform.rotation.eulerAngles.z < 355) {
            Debug.Log(this.transform.rotation.eulerAngles.z.ToString());
            Debug.Log("Switch to anti clock wise");
            clockWise = false;
        } else if (this.transform.rotation.eulerAngles.z > 180 && this.transform.rotation.eulerAngles.z < 200) {
            Debug.Log(this.transform.rotation.eulerAngles.z.ToString());
            Debug.Log("Switch to clock wise");
            clockWise = true;
        }

        if (clockWise) {
            transform.RotateAround(transform.position, -this.transform.forward, 30 * Time.deltaTime);
        } else {
            transform.RotateAround(transform.position, this.transform.forward, 30 * Time.deltaTime);
        }
    }
}
