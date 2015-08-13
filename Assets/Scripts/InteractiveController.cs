using UnityEngine;
using System.Collections;

public class InteractiveController : MonoBehaviour {

	/*
	 * Statics methods
	 */

	public static bool beaconOpened = false;
	public static bool debugMode = false;
	public static string actualView = "none";
	public static string actualSubView = "none";

	public static string key_pressed;
	public static float time_pressed;

	/*
	 * Instaced methods
	 */

	// Delegate vars	
	public bool _DebugMode = false;
	public bool _StarWithStars = true;
	public bool _BeaconOpened = false;
	public string _ActualView;
	public string _keyPressed;

	// Object Vars
	public GameObject Stars;
	public float TimeToStars = 0.5f;
	private float TimeInit;
	private bool cacheInitStars = false;
	
	public Transform BgBlurViewer;
	public Transform BgBlurPanel;

	public string PasswordToRebot;
	public string PasswordToExit;

	private float TimeActual;
	private float TimeStep = 1f;

	void Awake () {
		TimeActual = Time.time;
	}

	void Update () {
		TimeActual = Time.time;

		debugMode = _DebugMode;
		_BeaconOpened = beaconOpened;
		_ActualView = actualView;
		_keyPressed = key_pressed;

		if (TimeActual - time_pressed > TimeStep) {
			key_pressed = "";
		}

		if (key_pressed == PasswordToRebot) {
			Debug.Log("Rebot Interactive");
			Application.LoadLevel("pool");
		}
		
		if (key_pressed == PasswordToExit) {
			Debug.Log("Exit Interactive");
			Application.Quit();
		}

		if (!cacheInitStars && Time.time > TimeToStars) {
			BgBlurViewer.animation.Play("blur_meiumFadeOut");
			BgBlurPanel.animation.Play("blur_meiumFadeOut");
			if (_StarWithStars) {
				Stars.SetActive(true);
			}
			cacheInitStars = true;
		}
	}
}
