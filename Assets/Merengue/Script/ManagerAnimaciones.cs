using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ManagerAnimaciones : MonoBehaviour {

	public bool OneDetect;
	public static bool Detecto;
	public Button Btn1;
	public Button Btn2;
	public Button Btn3;
	public Button Btn4;

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
	public bool SaltandoFinal;
	public float ContadorSalto;
	public float ContadorSaltoDos;

	public AudioSource audios;
	public AudioClip audioWalk;
	public AudioClip audioJump;
	public AudioClip audioDormir;
	public AudioClip Vacio;

	public GameObject SonidoONbtn;
	public GameObject SonidoOFFbtn;
	public AudioSource MusicaFondo;



	void Start(){
		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		audios = GetComponent<AudioSource> ();
		Parado ();
	}

	public void Parado(){
		if((currentAnimation != "Idle")&&(!SaltandoFinal)){
			Gato.GetComponent<Animation>().Play("Idle Cat");
			Perro.GetComponent<Animation>().Play("Idle Dog");
			Tortuga.GetComponent<Animation>().Play("Idle Turtle");
			Lechuza.GetComponent<Animation>().Play("Idle Owl");
			//Rata.GetComponent<Animation>().Play("Idle Rat");
			currentAnimation = "Idle";
			audios.clip = Vacio;
			audios.Stop ();
			audios.loop = false;
			Caminando = false;
		}
	}
	public void Caminar(){
		if((currentAnimation != "Walk")&&(!SaltandoFinal)){
			Gato.GetComponent<Animation>().Play("Walk Cat");
			Perro.GetComponent<Animation>().Play("Run Dog");
			Tortuga.GetComponent<Animation>().Play("Walk Turtle");
			Lechuza.GetComponent<Animation>().Play("Walk Owl");
			//Rata.GetComponent<Animation>().Play("Walk Rat");
			currentAnimation = "Walk";
			audios.clip = audioWalk;
			audios.Play ();
			audios.loop = true;
			Caminando = true;
		}
	}

	public void Dormir(){
		if((currentAnimation != "Sleep")&&(!SaltandoFinal)){
			Gato.GetComponent<Animation>().Play("Sleep Cat");
			Perro.GetComponent<Animation>().Play("Sleep Dog");
			Tortuga.GetComponent<Animation>().Play("Sleep Turtle");
			Lechuza.GetComponent<Animation>().Play("Sleep Owl");
			//Rata.GetComponent<Animation>().Play("Sleep Rat");
			currentAnimation = "Sleep";
			audios.clip = audioDormir;
			audios.Play ();
			audios.loop = true;
			Caminando = false;

		}
	}

	public void Saltar(){
		if(!Saltando){
			SaltandoFinal = true;
			Saltando = true;
			Salto1 = true;
			Gato.GetComponent<Animation> ().Play ("Jump Up Cat");
			Perro.GetComponent<Animation> ().Play ("Jump Up Dog");
			Tortuga.GetComponent<Animation> ().Play ("Jump Up Turtle");
			Lechuza.GetComponent<Animation> ().Play ("Jump Up Owl");
			//Rata.GetComponent<Animation> ().Play ("Jump Up Rat");
			audios.clip = audioJump;
			audios.Play ();
			audios.loop = false;
			Debug.Log ("ASD");
			currentAnimation = "Jump";
		}
	}

	public void Cayendo(){
		Salto2 = true;
		Gato.GetComponent<Animation> ().Play ("Fall Cat");
		Perro.GetComponent<Animation> ().Play ("Fall Dog");
		Tortuga.GetComponent<Animation> ().Play ("Fall Turtle");
		Lechuza.GetComponent<Animation> ().Play ("Fall Owl");
		//Rata.GetComponent<Animation> ().Play ("Fall Rat");
	}

	void Update(){

		CameraDevice.Instance.SetFocusMode (CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

		if (Salto1) {
			ContadorSalto += Time.deltaTime;
		}
		if (ContadorSalto >= 0.8f) {
			Salto1 = false;
			Cayendo ();
			ContadorSalto = 0;
		}
		if (Salto2) {
			ContadorSaltoDos += Time.deltaTime;
		}
		if (ContadorSaltoDos >= 0.8f) {
			Salto2 = false;
			ContadorSaltoDos = 0;
			Salto3 = true;
		}

		if (Salto3) {
			Gato.GetComponent<Animation>().Play("Idle Cat");
			Perro.GetComponent<Animation>().Play("Idle Dog");
			Tortuga.GetComponent<Animation>().Play("Idle Turtle");
			Lechuza.GetComponent<Animation>().Play("Idle Owl");
			//Rata.GetComponent<Animation>().Play("Idle Rat");
			Salto3 = false;
			Saltando = false;
			SaltandoFinal = false;
		}

		if (Detecto) {
			if (!OneDetect) {
				Parado ();
				OneDetect = true;
			}

			Btn1.interactable = true;
			Btn2.interactable = true;
			Btn3.interactable = true;
			Btn4.interactable = true;
			if (!audios.isPlaying) {
				if (currentAnimation != "Jump") {
					audios.Play ();
					audios.loop = true;
				} else {
					audios.clip = Vacio;
					audios.Stop ();
					audios.loop = false;
				}
			}
		} else {
			OneDetect = false;
			Btn1.interactable = false;
			Btn2.interactable = false;
			Btn3.interactable = false;
			Btn4.interactable = false;
			audios.Stop ();
			audios.loop = false;
		}
	}


	public void SonidoON(){
//		SonidoONbtn.SetActive (false);
//		SonidoOFFbtn.SetActive (true);
		MusicaFondo.Play ();
	}

	public void SonidoOFF(){
//		SonidoONbtn.SetActive (true);
//		SonidoOFFbtn.SetActive (false);
		MusicaFondo.Pause ();
	}

	public void GoToMenu(){
		Application.LoadLevel ("Menu");
	}
	public void ExitBtn(){
		Application.Quit ();
	}
}
