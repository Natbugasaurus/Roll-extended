using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public float rotateSpeedX;
    public float rotateSpeedZ;

    private Vector3 rotateDirectionX;
    private Vector3 rotateDirectionZ;
    private Vector3 rotateDirection;
    private Vector3 currentRotation;

    void Start () {

	}
		
	void Update () {
        //ROTATION CONTROLS
        rotateDirectionX = new Vector3(Input.GetAxis("Vertical"), 0, 0);
        rotateDirectionZ = new Vector3(0, 0, -Input.GetAxis("Horizontal"));
        rotateDirectionX *= rotateSpeedX;
        rotateDirectionZ *= rotateSpeedZ;
        rotateDirection = rotateDirectionX + rotateDirectionZ;

        transform.Rotate(rotateDirection);

        //I GUESS THIS IS FINE
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.03f);
    }
}
