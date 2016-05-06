using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelSeven : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource b;
	public AudioSource d;
	public AudioSource g;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[5];
		melody [0] = "c";
		melody [1] = "e";
		melody [2] = "g";
		melody [3] = "d";
		melody [4] = "b";

		userInput = new string[5];
		audioPlaying = true;
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		e.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
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
			}else if (note.Equals ("d")) {
				d.Play ();
			}else if (note.Equals ("b")) {
				b.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 5) {
				didWin ();
			}
		}

	}

	public void didWin(){
		for (int i = 0; i < 5; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
				break;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level7", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level7")) {
				PlayerPrefs.SetString ("level7", "false");
			}
		}
	}
}
