﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelThree : MonoBehaviour {
	public GameObject endImageWin;
	public GameObject endImageLose;
	public string[] melody;
	public string[] userInput;
	public bool audioPlaying;
	public AudioSource c;
	public AudioSource e;
	public AudioSource g;
	public int numClicked;
	public bool iswinning;

	// Use this for initialization
	IEnumerator Start () {
		melody = new string[7];
		melody [0] = "c";
		melody [1] = "e";
		melody [2] = "g";
		melody [3] = "e";
		melody [4] = "c";
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
		e.Play ();
		yield return new WaitForSeconds (0.7f);
		c.Play ();
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
			PlayerPrefs.SetString ("level3", "true");
		} else {
			if (!PlayerPrefs.HasKey ("level3")) {
				
				PlayerPrefs.SetString ("level3", "false");
			}
			audioPlaying = true;
			endImageLose.SetActive (true);
		}
	}
}
