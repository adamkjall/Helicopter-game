using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehavior : MonoBehaviour {

    public float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // infinitely rotate this coin about the Y axis in world space
        transform.Rotate(0, speed, 0, Space.World);

    }
}
