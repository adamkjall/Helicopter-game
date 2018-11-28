using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBehavior : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        // despawn object if it goes past the left edge of the screen
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
        else
        {
          
            transform.Translate(-GameOverText.speed * Time.deltaTime * speed, 0, 0, Space.World);
        }
    }
}
