using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelFifteen : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource g;
	public AudioSource d;
	public AudioSource a;
	public int numClicked;
	public bool iswinning;


	// Use this for initialization
	IEnumerator  Start () {
		melody = new string[7];
		melody [0] = "a";
		melody [1] = "d";
		melody [2] = "a";
		melody [3] = "a";
		melody [4] = "d";
		melody [5] = "c";
		melody [6] = "g";

		userInput = new string[7];
		audioPlaying = true;

		a.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		d.Play ();
		yield return new WaitForSeconds (0.7f);
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);


		numClicked = 0;
		audioPlaying = false;
	}

	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("c")) {
				c.Play ();
			} else if (note.Equals ("g")) {
				g.Play ();
			} else if (note.Equals ("d")) {
				d.Play ();
			} else if (note.Equals ("a")) {
				a.Play ();
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 7) {
				didWin ();
			}
		}

	}
		
	public void didWin(){
		for (int i = 0; i < 7; i++){
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level15", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level15")) {
				PlayerPrefs.SetString ("level15", "false");
			}
		}
	}
}
