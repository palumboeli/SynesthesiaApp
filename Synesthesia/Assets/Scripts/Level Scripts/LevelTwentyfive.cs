using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwentyfive : MonoBehaviour {
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
		melody = new string[7];
		melody [0] = "b";
		melody [1] = "a";
		melody [2] = "g";
		melody [3] = "g";
		melody [4] = "a";
		melody [5] = "g";
		melody [6] = "e";

		userInput = new string[7];
		audioPlaying = true;

		b.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
		yield return new WaitForSeconds (0.7f);
		a.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
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
			PlayerPrefs.SetString ("level25", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level25")) {
				PlayerPrefs.SetString ("level25", "false");
			}
		}
	}
}