using UnityEngine;
using System.Collections;

public class Editor : MonoBehaviour {

	public GameObject tilePrefab;

	void Start () 
	{
		Tile tile;

		GameObject jim = (GameObject)Instantiate(tilePrefab);
		//((GameObject)Instantiate(lvlPrefab,lvlPos.transform.position,Quaternion.identity)).GetComponent<Lvl>();

		print ("I made a tile");

		tile = jim.GetComponent<Tile>();
		tile.Init(new Vector2(1,1),tileType.grass);
	}

}
