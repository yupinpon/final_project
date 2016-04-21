
//using UnityEngine.Texture2D;

var guiSkin : GUISkin;
var blackTexture : UnityEngine.Texture2D;

var healthPoint :float;
var healthRegen : float;
var healthRegentEnabled = true;

function Start () {

}

function Update () {
	if(healthRegentEnabled == true && healthPoint < 100){
		healthPoint -= healthRegen * Time.deltatime;

	}
	if (healthPoint >100){
		healthPoint = 100;
	}
	Application.LoadLavel("Game Over");
	healthPoins = 0;
	healthRegenEnabled = false;
}

function onGUI(){
	GUI.Skin = guiSkin;
	GUI.Label(new Rect (Screen.width -130, Screen.hight-90,200,50),healthPoint.toString);
}

