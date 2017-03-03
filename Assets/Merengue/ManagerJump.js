#pragma strict
#pragma downcast


private var currentAnimation : String;

var cat : GameObject;
 




public function Jump(){
if(currentAnimation != "Jump"){
		BlendAllCharactersToZero();
		cat.GetComponent(JumpTest).enabled = true;
		currentAnimation = "Jump";
	}
}

function BlendAllCharactersToZero(){
	BlendAllToZero(cat);

	cat.GetComponent(JumpTest).enabled = false;
}

function BlendAllToZero(character : GameObject){
	var animation = character.GetComponent.<Animation>();
	for(var state : AnimationState in animation){
		animation.Blend(state.name, 0);
	}
}