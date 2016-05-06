using UnityEngine;
using System.Collections;

public class levelMenuLoad : MonoBehaviour {
	public GameObject level2Icon;
	public GameObject level3Icon;
	public GameObject level4Icon;
	public GameObject level5Icon;
	public GameObject level6Icon;
	public GameObject level7Icon;
	public GameObject level8Icon;
	public GameObject level9Icon;
	public GameObject level10Icon;
	public GameObject level11Icon;
	public GameObject level12Icon;
	public GameObject level13Icon;
	public GameObject level14Icon;
	public GameObject nextLevel;


	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("level1")){
			if (PlayerPrefs.GetString ("level1").Equals ("true")) {
				level2Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level2")){
			if (PlayerPrefs.GetString ("level2").Equals ("true")) {
				level3Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level3")){
			if (PlayerPrefs.GetString ("level3").Equals ("true")) {
				level4Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level4")){
			if (PlayerPrefs.GetString ("level4").Equals ("true")) {
				level5Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level5")){
			if (PlayerPrefs.GetString ("level5").Equals ("true")) {
				level6Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level6")){
			if (PlayerPrefs.GetString ("level6").Equals ("true")) {
				level7Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level7")){
			if (PlayerPrefs.GetString ("level7").Equals ("true")) {
				level8Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level8")){
			if (PlayerPrefs.GetString ("level8").Equals ("true")) {
				level9Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level9")){
			if (PlayerPrefs.GetString ("level9").Equals ("true")) {
				level10Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level10")){
			if (PlayerPrefs.GetString ("level10").Equals ("true")) {
				level11Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level11")){
			if (PlayerPrefs.GetString ("level11").Equals ("true")) {
				level12Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level12")){
			if (PlayerPrefs.GetString ("level12").Equals ("true")) {
				level13Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level13")){
			if (PlayerPrefs.GetString ("level13").Equals ("true")) {
				level14Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level14")){
			if (PlayerPrefs.GetString ("level14").Equals ("true")) {
				nextLevel.SetActive (true);
			}
		}
	}
}
