

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
		healthPoint -= healthRegen * Time.deltaTime;

	}
	if (healthPoint >100) {
		healthPoint = 100;
	}
	//UpdateHealth();
	if(healthPoint <=0) {
	Application.LoadLevel("Game Over");
	healthPoint = 0;
	healthRegentEnabled = false;
	}
}

function onGUI(){
	GUI.skin = guiSkin;
	GUI.Label(new Rect (Screen.width -130, Screen.height-90,200,50),healthPoint.ToString("F0"));
}

	//function UpdateHealth() {
	//	StartCoroutine ("TimeScrip");
//		heartText.text = "Heart 3 : " + healthPoint;
//		}
