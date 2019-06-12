using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	public DisplayData displayData;
	public float scrollSpeed;
	private Renderer render;
	public bool isMoving;
	// Use this for initialization
	void Start () {
		scrollSpeed = -0.025f;
		render = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (displayData.GetAttetionValue() > 70) {
			Vector2 currentOffset = render.material.GetTextureOffset ("_MainTex");
			Vector2 deltaOffset = new Vector2(currentOffset.x + scrollSpeed, 0);
			render.material.SetTextureOffset ("_MainTex", deltaOffset);
		}
	}
}
