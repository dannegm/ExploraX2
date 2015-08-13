using System;
using UnityEngine;
using TouchScript.Gestures;

public class SetSubView : MonoBehaviour {
	public string SubViewName;
	
	private bool canSetSubView = false;
	void Update () {
		if (canSetSubView) {
			InteractiveController.actualSubView = SubViewName;
			canSetSubView = false;
		}
	}
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		canSetSubView = true;
	}
}
