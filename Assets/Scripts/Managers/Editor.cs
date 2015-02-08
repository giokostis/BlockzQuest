using UnityEngine;
using System.Collections;

public class Editor : MonoBehaviour {

	public GameObject tilePrefab;

	void Start () 
	{
	
		Tile tile = ((GameObject)Instantiate(tilePrefab,new Vector2(0,0),Quaternion.identity)).GetComponent<Tile>();
		tile.Init(new Vector2(0,0),tileType.stone);


	}

}
