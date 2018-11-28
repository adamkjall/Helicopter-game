using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBehavior : MonoBehaviour {

    public float speed = 10;

    //public ParticleSystem explosion;
    //public AudioSource explosionSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
	}

   

    public void Explode()
    {
       

        Destroy(gameObject);
    }

}
