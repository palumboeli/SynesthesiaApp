using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelSix : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource b;
	public AudioSource d;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[7];
		melody [0] = "b";
		melody [1] = "d";
		melody [2] = "b";
		melody [3] = "d";
		melody [4] = "b";
		melody [5] = "d";
		melody [6] = "d";

		userInput = new string[7];
		audioPlaying = true;
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
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
			}else if (note.Equals ("d")) {
				d.Play ();
			}else if (note.Equals ("b")) {
				b.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 7) {
				didWin ();
			}
		}

	}
		
	public void didWin(){
		for (int i = 0; i < 7; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
				break;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level6", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level6")) {
				PlayerPrefs.SetString ("level6", "false");
			}
		}
	}
}
