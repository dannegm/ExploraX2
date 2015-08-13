using System;
using UnityEngine;
using TouchScript.Gestures;

public class ShowHide : MonoBehaviour {

	public Transform Container;
	public string AnimIn;
	public string AnimOut;

	private bool isOpen = false;
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}

	void HandleTapped (object sender, EventArgs e) {
		if (!isOpen) {
			Container.animation.Play (AnimIn);
		} else {
			Container.animation.Play (AnimOut);
		}
		isOpen = !isOpen;
	}
}
