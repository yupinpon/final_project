#pragma strict

var damage = 10;
var damageTimer : float;
var healthScript : Health;

function Update () {
	if (healthScript.healthPoints <=0){
	Destroy (gameObjet);
	}

}
function OnTriggerEnter (other : Collider){
	if (other.tag == "Player"){
		healthScript.healthPoints -= damage;
	}
}