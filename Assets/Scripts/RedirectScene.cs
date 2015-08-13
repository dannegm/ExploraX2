using UnityEngine;
using System.Collections;

public class RedirectScene : MonoBehaviour {

	public string Scene;
	public float TimeToRedirect = 5f;
	private float TimeActual;

	// Use this for initialization
	void Awake () {
		TimeActual = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > (TimeActual + TimeToRedirect)) {
			Application.LoadLevel(Scene);
		}
	}
}
