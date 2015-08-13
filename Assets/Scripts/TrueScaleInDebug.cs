using UnityEngine;
using System.Collections;

public class TrueScaleInDebug : MonoBehaviour {
	private bool cacheScale = false;
	private bool cacheChange = true;
	
	public Vector3 TrueScale;
	public Vector3 HideScale;
	void Awake () {
		if (!InteractiveController.debugMode) {
			transform.localScale = HideScale;
		}
	}
}
