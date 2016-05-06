using UnityEngine;
using System.Collections;

public class levelPage2 : MonoBehaviour {
	public GameObject level15Icon;
	public GameObject level16Icon;
	public GameObject level17Icon;
	public GameObject level18Icon;
	public GameObject level19Icon;
	public GameObject level20Icon;
	public GameObject level21Icon;
	public GameObject level22Icon;
	public GameObject level23Icon;
	public GameObject level24Icon;
	public GameObject level25Icon;
	public GameObject level26Icon;
	public GameObject level27Icon;
	public GameObject level28Icon;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("level14")){
			if (PlayerPrefs.GetString ("level14").Equals ("true")) {
				level15Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level15")){
			if (PlayerPrefs.GetString ("level15").Equals ("true")) {
				level16Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level16")){
			if (PlayerPrefs.GetString ("level16").Equals ("true")) {
				level17Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level17")){
			if (PlayerPrefs.GetString ("level17").Equals ("true")) {
				level18Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level18")){
			if (PlayerPrefs.GetString ("level18").Equals ("true")) {
				level19Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level19")){
			if (PlayerPrefs.GetString ("level19").Equals ("true")) {
				level20Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level20")){
			if (PlayerPrefs.GetString ("level20").Equals ("true")) {
				level21Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level21")){
			if (PlayerPrefs.GetString ("level21").Equals ("true")) {
				level22Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level22")){
			if (PlayerPrefs.GetString ("level22").Equals ("true")) {
				level23Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level23")){
			if (PlayerPrefs.GetString ("level23").Equals ("true")) {
				level24Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level24")){
			if (PlayerPrefs.GetString ("level24").Equals ("true")) {
				level25Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level25")){
			if (PlayerPrefs.GetString ("level25").Equals ("true")) {
				level26Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level26")){
			if (PlayerPrefs.GetString ("level26").Equals ("true")) {
				level27Icon.SetActive (true);
			}
		}
		if(PlayerPrefs.HasKey("level27")){
			if (PlayerPrefs.GetString ("level27").Equals ("true")) {
				level28Icon.SetActive (true);
			}
		}
	}
}
