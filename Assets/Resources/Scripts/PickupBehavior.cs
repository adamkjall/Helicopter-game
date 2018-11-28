using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Shot") {
            other.transform.parent.gameObject.GetComponent<ShotBehavior>().Explode();
        } else
        {
            other.transform.parent.GetComponent<HeliController>().Pickup(gameObject);
        }
        
        Destroy(gameObject);
    }
}
