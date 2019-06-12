using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
	public float speed;
	public Rigidbody2D rb;
	public Spawn spawn;
	public DisplayData displaydata;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		spawn = GameObject.Find ("spawn").GetComponent<Spawn> ();
		displaydata = GameObject.Find ("DisplayDataDemo").GetComponent<DisplayData> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(displaydata.GetAttetionValue() > 70)
			rb.AddForce (new Vector2 (-speed * Time.deltaTime, 0), ForceMode2D.Impulse);

		if (transform.position.y < -5) {
			GameObject.Destroy (this.gameObject);
			spawn.spawnCount--;
		}
	}
}
