using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin=1f;
	public float spawnMax=2f;
	// Use this for initialization
	void Start () {
		spawn ();
	}
	
	// Update is called once per frame
	void spawn () {
		Instantiate(obj[Random.Range (0,obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("spawn", Random.Range (spawnMin, spawnMax));
		
	}
}
