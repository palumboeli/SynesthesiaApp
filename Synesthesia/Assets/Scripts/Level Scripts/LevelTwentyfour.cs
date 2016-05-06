using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwentyfour : MonoBehaviour {
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
	public AudioSource a;
	public AudioSource dhigh;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator  Start () {
		melody = new string[6];
		melody [0] = "a";
		melody [1] = "e";
		melody [2] = "b";
		melody [3] = "g";
		melody [4] = "d";
		melody [5] = "d";

		userInput = new string[6];
		audioPlaying = true;

		a.Play ();
		yield return new WaitForSeconds (0.7f);
		e.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
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
			} else if (note.Equals ("dhigh")) {
				dhigh.Play ();
			} else if (note.Equals ("a")) {
				a.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 6) {
				didWin ();
			}
		}

	}

	public void didWin(){
		for (int i = 0; i < 6; i++){
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level24", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level24")) {
				PlayerPrefs.SetString ("level24", "false");
			}
		}
	}
}

