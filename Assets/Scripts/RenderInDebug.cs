using UnityEngine;
using System.Collections;

public class RenderInDebug : MonoBehaviour {
	private bool cacheRender = false;
	private bool cacheChange = true;
	void Update () {
		if (InteractiveController.debugMode) {
			transform.GetComponent<Renderer>().enabled = true;
		} else {
			transform.GetComponent<Renderer>().enabled = false;
		}
	}
}
