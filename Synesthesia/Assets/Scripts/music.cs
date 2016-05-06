using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class music : MonoBehaviour {
	public AudioSource song;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().buildIndex != 0 && SceneManager.GetActiveScene ().buildIndex != 1 && SceneManager.GetActiveScene ().buildIndex != 30) {
			Destroy (transform.gameObject);
		}
	}
}
