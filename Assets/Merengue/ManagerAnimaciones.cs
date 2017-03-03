using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAnimaciones : MonoBehaviour {


	public GameObject Gato;
	public GameObject Perro;
	public string currentAnimation;

	void Start(){
		Parado ();
	}

	public void Parado(){
		if(currentAnimation != "Idle"){
			Gato.GetComponent<Animation>().Play("Idle Cat");
			Perro.GetComponent<Animation>().Play("Idle Dog");
			currentAnimation = "Idle";
		}
	}
	public void Caminar(){
		if(currentAnimation != "Walk"){
			Gato.GetComponent<Animation>().Play("Walk Cat");
			Perro.GetComponent<Animation>().Play("Walk Dog");
			currentAnimation = "Walk";
		}
	}
	public void Correr(){
		if(currentAnimation != "Run"){
			Gato.GetComponent<Animation>().Play("Run Cat");
			Perro.GetComponent<Animation>().Play("Run Dog");
			currentAnimation = "Run";
		}
	}

	public void Dormir(){
		if(currentAnimation != "Sleep"){
			Gato.GetComponent<Animation>().Play("Sleep Cat");
			Perro.GetComponent<Animation>().Play("Sleep Dog");
			currentAnimation = "Sleep";
		}
	}

}
