using UnityEngine;
[ExecuteInEditMode]

public class WidthCamera : MonoBehaviour {

	public int targetWidthSize = 480;
	public float pixelsToUnits = 100;
	void Update () {
		int height = Mathf.RoundToInt(targetWidthSize / (float)Screen.width * Screen.height);
		GetComponent<Camera>().orthographicSize = height /pixelsToUnits /2;
	}
}
