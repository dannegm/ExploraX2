using System;
using UnityEngine;
using TouchScript.Gestures;

public class PressDilate : MonoBehaviour {

	private Vector3 originalScale;
	public float rangeScale = 1.2f;

	private void Start () {
		originalScale = transform.localScale;
	}

	private void OnEnable() {
		transform.GetComponent<PressGesture>().Pressed += HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released += HandleReleased;
	}
	
	private void OnDisable() {
		transform.GetComponent<PressGesture>().Pressed -= HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released -= HandleReleased;
	}
	
	void HandleReleased (object sender, EventArgs e) {
		transform.localScale = originalScale;
	}
	
	void HandlePressed (object sender, EventArgs e) {
		transform.localScale = originalScale * rangeScale;
	}
}
