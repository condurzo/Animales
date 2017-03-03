#pragma strict

var cat : GameObject;
private var currentAnimation : String;

public function CatJump(){
if(currentAnimation != "Jump"){
		cat.GetComponent(JumpTest).enabled = true;
		currentAnimation = "Jump";
	}
}
