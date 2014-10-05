using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			switch(Application.loadedLevelName)
			{
			case "MainMenu": 
					Application.Quit();  
				break; 
			case "Game": 
			case "Editor": 
					Application.LoadLevel("MainMenu");
				break;
			}
		}
	}
}
