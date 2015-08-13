using UnityEngine;
using System.Collections;

public class VideoSource : MonoBehaviour {

	public Transform Canvas;
	public MovieTexture Video;
	public AudioSource Audio;

	void Awake () {
		Canvas.renderer.material.mainTexture = Video;
		Stop ();
	}

	public void Play () {
		Video.Play ();
		Audio.Play ();
	}
	public void Pause () {
		Video.Pause ();
		Audio.Pause ();
	}
	public void Replay () {
		Video.Stop ();
		Video.Play ();

		Audio.Stop ();
		Audio.Play ();
	}
	public void Stop () {
		Video.Stop ();
		Audio.Stop ();
	}
}
