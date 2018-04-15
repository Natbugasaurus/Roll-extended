using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    public Transform player;

	public float rotateSpeedX;
    public float rotateSpeedZ;

    private Vector3 rotateDirectionX;
    private Vector3 rotateDirectionZ;
    private Vector3 rotateDirection;
    private Vector3 currentRotation;

    void Start () {

	}
		
	void Update () {
        //Rotation controls
        //Get individual axis
        rotateDirectionX = new Vector3(Input.GetAxis("Vertical"), 0, 0);
        rotateDirectionZ = new Vector3(0, 0, -Input.GetAxis("Horizontal"));
        //Adjust by seperate rotation speeds
        rotateDirectionX *= rotateSpeedX;
        rotateDirectionZ *= rotateSpeedZ;

        //Combine
        rotateDirection = rotateDirectionX + rotateDirectionZ;

        //Apply rotation
        transform.Rotate(rotateDirection);

        //Lerp back to original positon
        //Also serves as a clamp when lerp amount is higher than rotation speed
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, 0.03f);
    }
}
