using UnityEngine;
using System.Collections;

public class VideoController : MonoBehaviour {

	public VideoSource[] Videos;
	private VideoSource video;

	private int a = 0;

	public void SetVideo(int v) {
		a = v;
		video = Videos [v];
	}

	public void Play () {
		video.Play ();
	}
	public void Pause () {
		video.Pause ();
	}
	public void Replay () {
		video.Replay ();
	}
	public void Stop () {
		video.Stop ();
	}
}
