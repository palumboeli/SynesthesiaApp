using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwentyeight : MonoBehaviour {
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
		melody = new string[8];
		melody [0] = "dhigh";
		melody [1] = "d";
		melody [2] = "dhigh";
		melody [3] = "g";
		melody [4] = "e";
		melody [5] = "c";
		melody [6] = "b";
		melody [7] = "g";

		userInput = new string[8];
		audioPlaying = true;

		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);
		e.Play ();
		yield return new WaitForSeconds (0.7f);
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
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
			PlayerPrefs.SetString ("level28", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level28")) {
				PlayerPrefs.SetString ("level28", "false");
			}
		}
	}
}

