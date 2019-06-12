using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public float timeToSpawn = 3;
	public float currentTime;
	public int spawnCount = 0;
	public GameObject boxPrefab;
	public DisplayData displaydata;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (displaydata.GetAttetionValue () > 70 && spawnCount < 2) {
			currentTime += Time.deltaTime;
			if (currentTime > timeToSpawn) {
				currentTime = 0f;
				timeToSpawn = Random.Range (3, 10);
				spawnCount++;
				Instantiate (boxPrefab, transform.position, Quaternion.identity);
			}
		}
	}
}
