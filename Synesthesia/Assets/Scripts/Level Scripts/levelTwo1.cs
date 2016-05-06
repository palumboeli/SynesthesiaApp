using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelTwo1 : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[2];
		melody [0] = "c";
		melody [1] = "e";
		userInput = new string[2];
		audioPlaying = true;
		c.Play ();
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
			}
			userInput [numClicked] = note;
			numClicked++;
			if (numClicked == 2) {
				didWin ();
			}
		}

	}

	public void didWin(){
		for (int i = 0; i < 2; i++) {
			if (!userInput [i].Equals (melody [i])) {
				iswinning = false;
				break;
			}
		}
		if (iswinning) {
			endImageWin.SetActive (true);
			audioPlaying = true;
			PlayerPrefs.SetString ("level2", "true");
		} else {
			if (!PlayerPrefs.HasKey ("level2")) {
				PlayerPrefs.SetString ("level2", "false");
			}
			endImageLose.SetActive (true);
			audioPlaying = true;
		}
	}
}
