using System;
using UnityEngine;
using TouchScript.Gestures;

public class VideoStop : MonoBehaviour {

	public VideoSource video;
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		video.Stop ();
	}
}
