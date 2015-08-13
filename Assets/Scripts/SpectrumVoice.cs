using UnityEngine;
using System.Collections;

public class SpectrumVoice : MonoBehaviour {
	
	private AudioSource audio;
	Transform cacheTransform;
	public float saclee;
	
	void Start() {
		audio = GetComponent<AudioSource>();
		cacheTransform = transform;
	}
	
	void Update() {
		float[] spectrum = audio.GetSpectrumData(256, 0, FFTWindow.BlackmanHarris);
		float i = spectrum[32] * 1000f;
		float scale = 30 + i;
		saclee = scale;
		if (scale < 36.5f) {
			cacheTransform.localScale = new Vector3 (scale, scale, scale);
		}
	}
}
