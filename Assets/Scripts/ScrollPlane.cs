using UnityEngine;
using System.Collections;

public class ScrollPlane : MonoBehaviour {

	public Transform MinReference;
	public Transform MaxReference;

	public float Min;
	public float Max;
	public bool canScroll = false;
	
	private Vector3 initialPosition;
	private Vector3 cachePosition;
	
	
	void Start () {
		initialPosition = transform.localPosition;
		cachePosition = transform.localPosition;

		Min = MinReference.localPosition.x - cachePosition.x;
		Max = cachePosition.x - MaxReference.localPosition.x;
	}
	void Update () {
		if (!InteractiveController.beaconOpened) {
			if (transform.localPosition.x <= Min) {
					transform.localPosition = new Vector3 (Min, cachePosition.y, cachePosition.z);
			}

			if (transform.localPosition.x >= Max) {
					transform.localPosition = new Vector3 (Max, cachePosition.y, cachePosition.z);
			}

			cachePosition = transform.localPosition;
			transform.localPosition = new Vector3 (cachePosition.x, initialPosition.y, cachePosition.z);
		} else {
			transform.localPosition = cachePosition;
		}
	}
}
