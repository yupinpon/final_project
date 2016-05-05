

var guiSkin : GUISkin;
var blackTexture : UnityEngine.Texture2D;

var healthPoint :float;
var healthRegen : float;
var healthRegentEnabled = true;
var text : UnityEngine.UI.Text;

function Start () {
}

function Update () {
    //text.heartText.text = "Heart AAAA";
	if(healthRegentEnabled == true && healthPoint < 100){
		healthPoint -= healthRegen * Time.deltatime;

	}
	if (healthPoint >100) {
		healthPoint = 100;
	}
	//UpdateHealth();
	if(healthPoint <=0) {
	Application.LoadLavel("Game Over");
	healthPoins = 0;
	healthRegenEnabled = false;
	}
}

function onGUI(){
	GUI.Skin = guiSkin;
	GUI.Label(new Rect (Screen.width -130, Screen.hight-90,200,50),healthPoint.ToString("F0"));
}

	//function UpdateHealth() {
	//	StartCoroutine ("TimeScrip");
//		heartText.text = "Heart 3 : " + healthPoint;
//		}
