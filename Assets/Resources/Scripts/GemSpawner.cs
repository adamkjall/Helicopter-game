using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnGems());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnGems() {
        while (true) {

            Instantiate(prefab, new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(5, 10));
        }
    }
}
