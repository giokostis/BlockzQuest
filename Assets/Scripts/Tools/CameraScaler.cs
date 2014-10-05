using UnityEngine;
using System.Collections;

public class CameraScaler : MonoBehaviour {

	public Transform graphics;

	void Awake()
	{
		float screenHeight = Screen.height;

		Camera.main.orthographicSize = (screenHeight/2f)/(float)Game.Manager.pixelToUnits;
		graphics.localScale = new Vector3(Game.Manager.scale,Game.Manager.scale,1);
	}
}
