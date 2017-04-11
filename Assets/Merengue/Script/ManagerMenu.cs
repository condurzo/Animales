using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMenu : MonoBehaviour {


	public void GoToHome () {
		Application.LoadLevel ("Home");
	}
	public void ExitApp(){
		Application.Quit ();
	}
}
