using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectResolutionGame : MonoBehaviour {

	public GameObject SounOffiPad;
	public GameObject ExitiPad;

	public GameObject SounOff;
	public GameObject Exiti;


	void Awake(){
		if ((Screen.width == 1536) && (Screen.height == 2048) || (Screen.width == 2048) && (Screen.height == 2732) || (Screen.width == 768) && (Screen.height == 1024) || (Screen.width == 1024) && (Screen.height == 1366)) {
			Debug.Log ("ES IPAD");
			SounOffiPad.SetActive (true);
			ExitiPad.SetActive (true);

			SounOff.SetActive (false);
			Exiti.SetActive (false);
		} else {
			Debug.Log ("no es iPad");
			SounOffiPad.SetActive (false);
			ExitiPad.SetActive (false);

			SounOff.SetActive (true);
			Exiti.SetActive (true);
		}
	}


}
