using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwentynine : MonoBehaviour {
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
		melody = new string[9];
		melody [0] = "b";
		melody [1] = "e";
		melody [2] = "g";
		melody [3] = "e";
		melody [4] = "c";
		melody [5] = "e";
		melody [6] = "a";
		melody [7] = "d";
		melody [8] = "a";

		userInput = new string[9];
		audioPlaying = true;

		b.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		g.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		c.Play ();
		yield return new WaitForSeconds (1);
		e.Play ();
		yield return new WaitForSeconds (1);
		a.Play ();
		yield return new WaitForSeconds (1);
		d.Play ();
		yield return new WaitForSeconds (1);
		a.Play ();
		yield return new WaitForSeconds (1);

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
			if (numClicked == 9) {
				didWin ();
			}
		}

	}

	public void replayMelody(){
		Start();
	}

	public void tryAgain(){
		int scene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}

	public void didWin(){
		for (int i = 0; i < 9; i++){
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level29", "true");
		} else {
			endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey ("level29")) {
				PlayerPrefs.SetString ("level29", "false");
			}
		}
	}
}

