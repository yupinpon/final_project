#pragma strict

var damage = 10;
var damageTimer : float;
var healthScript : Health;

function Update () {
	if (healthScript.healthPoint <=0){
	Destroy (gameObject);
	}

}
function OnTriggerEnter (other : Collider){
	if (other.tag == "Player"){
		healthScript.healthPoint -= damage;
	}
}