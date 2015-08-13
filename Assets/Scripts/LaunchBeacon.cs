using System;
using UnityEngine;
using TouchScript.Gestures;

public class LaunchBeacon : MonoBehaviour {
	public TapGesture[] Pines;
	public Transform Container;
	public string LaunchAnimationName;
	public string HideAnimationName;

	private int nPines;
	private int TouchetPines = 0;

	private bool active = false;
	private bool canAnim = false;

	void Start () {
		nPines = Pines.Length;
	}

	void Update () {
		if (TouchetPines >= nPines) {
			TouchetPines = 0;
			active = !active;
			canAnim = true;

			Debug.Log("Todos los pines preisonados");
		}

		if (active) {
			if (canAnim) {
				Container.animation.Play(LaunchAnimationName);
				canAnim = false;
			}
		} else {
			if (canAnim) {
				Container.animation.Play(HideAnimationName);
				canAnim = false;
			}
		}
	}
	
	private void OnEnable() {
		foreach (TapGesture pin in Pines) {
			pin.Tapped += delegate(object sender, EventArgs e) {
				TouchetPines++;
				Debug.Log(sender);
				Debug.Log(e);
				Debug.Log(pin);
			};
		}
	}
	
	private void OnDisable() {
		foreach (TapGesture pin in Pines) {
			pin.Tapped -= delegate(object sender, EventArgs e) {
				// Do Nothing
			};
		}
	}
}
