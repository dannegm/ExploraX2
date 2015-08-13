using System;
using UnityEngine;
using TouchScript.Gestures;

public class KeyPress : MonoBehaviour {
	public string Value;
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		InteractiveController.key_pressed += Value;
		InteractiveController.time_pressed = Time.time;
	}
}
