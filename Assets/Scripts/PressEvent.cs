using System;
using UnityEngine;
using TouchScript.Gestures;

public class PressEvent : MonoBehaviour {

	public Texture Normal;
	public Texture Pressed;
	
	private void OnEnable() {
		transform.GetComponent<PressGesture>().Pressed += HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released += HandleReleased;
	}
	
	private void OnDisable() {
		transform.GetComponent<PressGesture>().Pressed -= HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released -= HandleReleased;
	}

	void HandleReleased (object sender, EventArgs e) {
		transform.renderer.material.mainTexture = Normal;

	}

	void HandlePressed (object sender, EventArgs e) {
		transform.renderer.material.mainTexture = Pressed;
	}
}
