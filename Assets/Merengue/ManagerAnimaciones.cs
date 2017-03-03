using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAnimaciones : MonoBehaviour {


	public GameObject Gato;
	public string currentAnimation;

	public void Parado(){
		if(currentAnimation != "Idle"){
			//dog.GetComponent.<Animation>().Blend("Idle Dog");
			Gato.GetComponent<Animation>().Blend("Idle Cat");
			//turtle.GetComponent.<Animation>().Blend("Idle Turtle");
			//owl.GetComponent.<Animation>().Blend("Idle Owl");
			//rat.GetComponent.<Animation>().Blend("Idle Rat");
			currentAnimation = "Idle";
		}
	}
	public void Caminar(){
		if(currentAnimation != "Walk"){
			//dog.GetComponent.<Animation>().Blend("Walk Dog");
			Gato.GetComponent<Animation>().Blend("Walk Cat");
			//turtle.GetComponent.<Animation>().Blend("Walk Turtle");
			//owl.GetComponent.<Animation>().Blend("Walk Owl");
			//rat.GetComponent.<Animation>().Blend("Walk Rat");
			currentAnimation = "Walk";
		}
	}
	public void Correr(){
		if(currentAnimation != "Run"){
			//dog.GetComponent.<Animation>().Blend("Run Dog");
			Gato.GetComponent<Animation>().Blend("Run Cat");
			//turtle.GetComponent.<Animation>().Blend("Run Turtle");
			//owl.GetComponent.<Animation>().Blend("Run Owl");
			//rat.GetComponent.<Animation>().Blend("Run Rat");
			currentAnimation = "Run";
		}
	}

	public void Dormir(){
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
