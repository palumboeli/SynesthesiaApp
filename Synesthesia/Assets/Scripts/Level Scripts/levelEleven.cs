using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelEleven : MonoBehaviour {
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
public AudioSource dhigh;
public int numClicked;
public bool iswinning;

// Use this for initialization
IEnumerator  Start () {
	melody = new string[9];
	melody [0] = "d";
	melody [1] = "c";
	melody [2] = "g";
	melody [3] = "c";
	melody [4] = "b";
	melody [5] = "b";
	melody [6] = "g";
	melody [7] = "g";
	melody [8] = "d";
	userInput = new string[9];
	audioPlaying = true;
	d.Play ();
	yield return new WaitForSeconds (0.7f);
	c.Play ();
	yield return new WaitForSeconds (0.7f);
	g.Play ();
		yield return new WaitForSeconds (0.7f);
	c.Play ();
		yield return new WaitForSeconds (0.7f);
	b.Play ();
		yield return new WaitForSeconds (0.7f);
	b.Play ();
		yield return new WaitForSeconds (0.7f);
	g.Play ();
		yield return new WaitForSeconds (0.7f);
		g.Play ();
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
		} else if (note.Equals ("b")) {
			b.Play ();
		} else if (note.Equals ("d")) {
			d.Play ();
		} else if (note.Equals ("dhigh")) {
			dhigh.Play ();
		}
		userInput [numClicked] = note;
		numClicked++;
		if (numClicked == 9) {
			didWin ();
		}
	}

}

public void didWin(){
	for (int i = 0; i < 9; i++){
			
		if (!userInput [i].Equals (melody [i])) {
			print (userInput [i]);
			iswinning = false;
		}
	}
	if (iswinning) {
		endImageWin.SetActive (true);
			audioPlaying = true;
		PlayerPrefs.SetString ("level11", "true");
	} else {
		endImageLose.SetActive (true);
			audioPlaying = true;
			if (!PlayerPrefs.HasKey("level11")) {
			PlayerPrefs.SetString ("level11", "false");
		}
	}
}
}
