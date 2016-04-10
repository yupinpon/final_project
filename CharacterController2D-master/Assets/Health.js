
using UnityEngine.Texture;

var guiSkin : GUISkin;
var blackTexture : Textture2D;

var healthPoint :float;
var healthRegen : float;
var healthRegentEnabled = true;

function Start () {

}

function Update () {
	if(healthRegenEnabled == true && healthPoint < 100){
		healthPoint -= healthRegen * time.deltatime;
	}
	if (healthPoint >100){
		healthPoint = 100;
	}
	Application.LoadLavel("Game Over");
	healthPoins = 0;
	healthRegenEnabled = false;
}

function onGUI(){
	GUI.skin = guiSkin;
	GUI.Label(new rect (Screen.width -130, Screen.hight-90,200,50),healthPoints.toString);
}