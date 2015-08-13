using System;
using UnityEngine;
using TouchScript.Gestures;

public class TapAmin : MonoBehaviour {
	
	public Transform Container;
	public string AnimName;
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		Container.animation.Play (AnimName);
	}
}
