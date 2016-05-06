using UnityEngine;
using System.Collections;

public class levelOne : MonoBehaviour {
	public AudioSource c;
	public GameObject endImage;
	public bool audioPlaying;

	// Use this for initialization
	IEnumerator Start () {
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		audioPlaying = false;
	}

	public void onMouseDownGreen(){
		if (!audioPlaying) {
			c.Play ();
			endImage.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level1", "true");
		}

	}
}
