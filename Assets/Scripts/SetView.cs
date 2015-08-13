using System;
using UnityEngine;
using TouchScript.Gestures;

public class SetView : MonoBehaviour {
	public string ViewName;
	public bool Toggle = false;

	private bool canSetView = false;
	void Update () {
		if (!Toggle) {
			if (canSetView) {
					InteractiveController.actualView = ViewName;
					canSetView = false;
			}
		} else {
			if (canSetView) {
				if (InteractiveController.actualView != "none") {
					InteractiveController.actualView = "none";
				} else {
					InteractiveController.actualView = ViewName;
				}
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
