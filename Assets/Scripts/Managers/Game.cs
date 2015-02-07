using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Game{

	static public Game Manager = new Game();

	// Constants
	public float pixelToUnits = 100f;
	public float defaultWidth = 720;
	public float defaultHeight = 1280;

	// Lists - Dictionaries


	// Managers
	public Crypto Sequrity;

	// Helpers
	public Dimm dimm;

	// Booleans
	public bool pc;

	// Miscelenous
	public string ID;

	// Vars
	public float scale;


	private Game()
	{
		// Create Some Managers
		Sequrity = new Crypto();

		// Check if is the first time you open the game
		if (!PlayerPrefs.HasKey("ID")) 	FirstOpen();
		else 							Initialize();

		#if UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE
			pc = false;
		#else
			pc = true;	
		#endif

		#if UNITY_EDITOR
			pc = true;
		#endif

		DefineScale();
	}

	void FirstOpen()
	{
		Debug.Log("First Open !!");
	
		//Player ID
		ID = Random.Range(0,1000000).ToString();
		PlayerPrefs.SetString("ID",ID);

		Initialize();


	}

	void Initialize()
	{
		Debug.Log("Initialize !!");
		ID = PlayerPrefs.GetString("ID");
	}


	public void DefineScale()
	{
		// Set Game Graphics scale 
		scale = Screen.width/defaultWidth;
		if(defaultHeight*scale > Screen.height)
			scale = Screen.height/defaultHeight;
	}


	//  Control Actions
	public void Swype(swype move)
	{
		switch(move)
		{
		case swype.up: 		break;
		case swype.right: 	break;
		case swype.down: 	break;
		case swype.left: 	break;
		}
	}


	public string Encrypt(string data, string key)
	{
		string elif = "BlockzQuestProjectRules!";
		string enc = elif.Remove(elif.Length-key.Length)+key;
	
		return Sequrity.EncryptData(data.ToString(),enc);
	}

	public string Encrypt(int data, string key)
	{
		return Encrypt(data.ToString(),key);
	}

	public int Decrypt(string data, string key)
	{
		string elif = "BlockzQuestProjectRules!";
		string dec = elif.Remove(elif.Length-key.Length)+key;
		string decrypt;
		try 
		{
		 	decrypt = Sequrity.DecryptData(data,dec);
		}
		catch
		{
			decrypt = "0";
		}
		int msg =0;
		if (int.TryParse(decrypt,out msg)) return msg;
		else return 0;
	}

}