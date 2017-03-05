using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAnimaciones : MonoBehaviour {


	public GameObject Gato;
	public GameObject Perro;
	public GameObject Tortuga;
	public GameObject Lechuza;
	public GameObject Rata;

	public string currentAnimation;

	public static bool Caminando;
	public static bool Saltando;
	public bool Salto1;
	public static bool Salto2;
	public bool Salto3;
	public float ContadorSalto;

	void Start(){
		Parado ();
	}

	public void Parado(){
		if(currentAnimation != "Idle"){
			Gato.GetComponent<Animation>().Play("Idle Cat");
			Perro.GetComponent<Animation>().Play("Idle Dog");
			Tortuga.GetComponent<Animation>().Play("Idle Turtle");
			Lechuza.GetComponent<Animation>().Play("Idle Owl");
			Rata.GetComponent<Animation>().Play("Idle Rat");
			currentAnimation = "Idle";
			Caminando = false;
		}
	}
	public void Caminar(){
		if(currentAnimation != "Walk"){
			Gato.GetComponent<Animation>().Play("Walk Cat");
			Perro.GetComponent<Animation>().Play("Run Dog");
			Tortuga.GetComponent<Animation>().Play("Walk Turtle");
			Lechuza.GetComponent<Animation>().Play("Walk Owl");
			Rata.GetComponent<Animation>().Play("Walk Rat");
			currentAnimation = "Walk";
			Caminando = true;
		}
	}
	public void Correr(){
		if(currentAnimation != "Run"){
			Gato.GetComponent<Animation>().Play("Run Cat");
			Perro.GetComponent<Animation>().Play("Run Dog");
			Tortuga.GetComponent<Animation>().Play("Run Turtle");
			Lechuza.GetComponent<Animation>().Play("Run Owl");
			Rata.GetComponent<Animation>().Play("Run Rat");
			currentAnimation = "Run";
		}
	}

	public void Dormir(){
		if(currentAnimation != "Sleep"){
			Gato.GetComponent<Animation>().Play("Sleep Cat");
			Perro.GetComponent<Animation>().Play("Sleep Dog");
			Tortuga.GetComponent<Animation>().Play("Sleep Turtle");
			Lechuza.GetComponent<Animation>().Play("Sleep Owl");
			Rata.GetComponent<Animation>().Play("Sleep Rat");
			currentAnimation = "Sleep";
			Caminando = false;
		}
	}


	public void Saltar(){
		if(!Saltando){
		//if (currentAnimation != "Jump") {
			Saltando = true;
			Salto1 = true;
			Gato.GetComponent<Animation> ().Play ("Jump Up Cat");
			Perro.GetComponent<Animation> ().Play ("Jump Up Dog");
			Tortuga.GetComponent<Animation> ().Play ("Jump Up Turtle");
			Lechuza.GetComponent<Animation> ().Play ("Jump Up Owl");
			Rata.GetComponent<Animation> ().Play ("Jump Up Rat");
			Debug.Log ("ASD");
			//currentAnimation = "Jump";
		}
	}

	public void Cayendo(){
		Gato.GetComponent<Animation> ().Play ("Fall Cat");
		Perro.GetComponent<Animation> ().Play ("Fall Dog");
		Tortuga.GetComponent<Animation> ().Play ("Fall Turtle");
		Lechuza.GetComponent<Animation> ().Play ("Fall Owl");
		Rata.GetComponent<Animation> ().Play ("Fall Rat");
	}

	void Update(){
		if (Salto1) {
			ContadorSalto += Time.deltaTime;
		}
		if (ContadorSalto >= 0.8f) {
			Salto1 = false;
			Cayendo ();
			ContadorSalto = 0;
		}
		if (Salto2) {
			switch (currentAnimation) {
			case "Idle":
				Gato.GetComponent<Animation> ().Play ("Idle Cat");
				Perro.GetComponent<Animation> ().Play ("Idle Dog");
				Tortuga.GetComponent<Animation> ().Play ("Idle Turtle");
				Lechuza.GetComponent<Animation> ().Play ("Idle Owl");
				Rata.GetComponent<Animation> ().Play ("Idle Rat");
				Salto2 = false;
				break;
			case "Walk":
				Gato.GetComponent<Animation>().Play("Walk Cat");
				Perro.GetComponent<Animation>().Play("Run Dog");
				Tortuga.GetComponent<Animation>().Play("Walk Turtle");
				Lechuza.GetComponent<Animation>().Play("Walk Owl");
				Rata.GetComponent<Animation>().Play("Walk Rat");
				Salto2 = false;
				break;
			case "Sleep":
				Gato.GetComponent<Animation>().Play("Sleep Cat");
				Perro.GetComponent<Animation>().Play("Sleep Dog");
				Tortuga.GetComponent<Animation>().Play("Sleep Turtle");
				Lechuza.GetComponent<Animation>().Play("Sleep Owl");
				Rata.GetComponent<Animation>().Play("Sleep Rat");
				Salto2 = false;
			break;
		}
		}

	}

}
