using System;
using UnityEngine;
using TouchScript.Gestures;

public class SetViewIfView : MonoBehaviour {
	public string IfView;
	public string ViewName;

	private bool canSetView = false;
	void Update () {
		if (canSetView) {
			if (InteractiveController.actualView == IfView) {
				InteractiveController.actualView = ViewName;
				canSetView = false;
			}
		}
	}
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		canSetView = true;
	}
}
