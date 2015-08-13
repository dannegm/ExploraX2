﻿using System;
using UnityEngine;
using TouchScript.Gestures;

public class PlayAudio : MonoBehaviour {
	public AudioSource Sound;
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		Sound.Play ();
	}
}
