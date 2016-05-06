using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelFive : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public AudioSource b;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		iswinning = true;
		melody = new string[7];
		melody [0] = "c";
		melody [1] = "e";
		melody [2] = "g";
		melody [3] = "b";
		melody [4] = "b";
		melody [5] = "c";
		melody [6] = "c";
		userInput = new string[7];
		audioPlaying = true;
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		e.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		c.Play ();
		yield return new WaitForSeconds (0.7f);
		c.Play ();
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
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level5", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level5")) {
				PlayerPrefs.SetString ("level5", "false");
			}
		}
	}
}
