using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSixteen : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource e;
	public AudioSource b;
	public AudioSource dhigh;
	public AudioSource a;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator  Start () {
		melody = new string[8];
		melody [0] = "e";
		melody [1] = "b";
		melody [2] = "dhigh";
		melody [3] = "a";
		melody [4] = "a";
		melody [5] = "dhigh";
		melody [6] = "b";
		melody [7] = "e";

		userInput = new string[8];
		audioPlaying = true;

		e.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		dhigh.Play ();
		yield return new WaitForSeconds (0.7f);
		b.Play ();
		yield return new WaitForSeconds (0.7f);
		e.Play ();
		yield return new WaitForSeconds (0.7f);


		numClicked = 0;
		audioPlaying = false;
	}

	public void click(string note){
		if (!audioPlaying) {
			if (note.Equals ("e")) {
				e.Play ();
			} else if (note.Equals ("b")) {
				b.Play ();
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
			PlayerPrefs.SetString ("level16", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level16")) {
				PlayerPrefs.SetString ("level16", "false");
			}
		}
	}
}