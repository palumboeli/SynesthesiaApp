using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelEight : MonoBehaviour {
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
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[3];
		melody [0] = "d";
		melody [1] = "d";
		melody [2] = "d";
		userInput = new string[3];
		audioPlaying = true;
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
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
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 3) {
				didWin ();
			}
		}

	}

	public void didWin(){
		for (int i = 0; i < 3; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level8", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level8")) {
				PlayerPrefs.SetString ("level8", "false");
			}
		}
	}
}
