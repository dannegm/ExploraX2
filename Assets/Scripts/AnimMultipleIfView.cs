﻿using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimMultipleIfView : MonoBehaviour {
	public Transform[] Container;
	public string IfView;
	public string AnimName;
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		if (InteractiveController.actualView == IfView) {
			foreach (Transform c in Container) {
				c.animation.Play (AnimName);
			}
		}
	}
}
