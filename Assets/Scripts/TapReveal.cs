using System;
using UnityEngine;
using TouchScript.Gestures;

public class TapReveal : MonoBehaviour {
	//public SetView view;

	public Transform Container;
	public string LaunchAnimationName;
	public string HideAnimationName;
	public AudioSource SoundOpen;
	public AudioSource SoundClose;
	

	public bool active = false;

	//public Transform[] Insiders;
	//public string[] Animates;

	private bool canAnim = false;
	
	private int FramesToSetNoneView = 5;
	private int FramesActuals = 0;
	
	void Update () {
		if (!InteractiveController.beaconOpened) {
			if (active) {

				if (canAnim) {
					InteractiveController.beaconOpened = true;
					Container.animation.Play(LaunchAnimationName);
					canAnim = false;
					SoundOpen.Play();
				}
			}
		}

		if (!active) {

			if (canAnim) {
				InteractiveController.beaconOpened = false;
				Container.animation.Play(HideAnimationName);
				canAnim = false;
				SoundClose.Play();
			}
		}
	}
	
	private void OnEnable() {
		GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		canAnim = true;
		if (!active) {
			if (!InteractiveController.beaconOpened) {
				active = true;

				//for (int x = 0; x > Insiders.Length; x++) {
					//Insiders[x].animation.Play( Animates[x] );
					
				//}
			}
		} else {
			active = false;
		}
	}
}
