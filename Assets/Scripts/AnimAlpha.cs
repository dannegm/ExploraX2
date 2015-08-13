using UnityEngine;
using System.Collections;

public class AnimAlpha : MonoBehaviour {
	public float Alpha = 1;
	Color color;

	// Use this for initialization
	void Start () {
		color = transform.renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		color.a = Alpha;
		transform.renderer.material.color = color;
	
	}
}
