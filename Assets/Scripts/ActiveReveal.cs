using System;
using UnityEngine;
using TouchScript.Gestures;

public class ActiveReveal : MonoBehaviour {
	public Collider Reveal;
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		Reveal.enabled = true;
	}
}
