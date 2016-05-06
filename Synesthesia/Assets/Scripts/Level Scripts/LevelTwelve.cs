using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwelve : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public AudioSource b;
	public AudioSource d;
	public AudioSource dhigh;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[8];
		melody [0] = "d";
		melody [1] = "dhigh";
		melody [2] = "d";
		melody [3] = "dhigh";
		melody [4] = "dhigh";
		melody [5] = "d";
		melody [6] = "dhigh";
		melody [7] = "d";
		userInput = new string[8];
		audioPlaying = true;
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);

		numClicked = 0;
		audioPlaying = false;
	}

	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("e")) {
				e.Play ();
			} else if (note.Equals ("c")) {
				c.Play ();
			} else if (note.Equals ("g")) {
				g.Play ();
			} else if (note.Equals ("b")) {
				b.Play ();
			} else if (note.Equals ("d")) {
				d.Play ();
			} else if (note.Equals ("dhigh")) {
				dhigh.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 8) {
				didWin ();
			}
		}

	}

	public void didWin(){
		for (int i = 0; i < 8; i++){
		if (!userInput [i].Equals (melody [i])) {
			iswinning = false;
		}
	}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level12", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level12")) {
				PlayerPrefs.SetString ("level12", "false");
			}
		}
	}
}