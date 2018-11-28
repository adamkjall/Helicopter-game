using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehavior : MonoBehaviour {

    public ParticleSystem explosion;
    public AudioSource explosionSound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Explode()
    {
        explosionSound.Play();

        // set explosion position to helicopter's and emit
        explosion.transform.position = transform.position;
        explosion.Play();

        Destroy(gameObject);
    }
}
