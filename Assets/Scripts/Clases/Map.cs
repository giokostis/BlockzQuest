using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	Vector2 dimensions;
	public GameObject tilePrefab;

	void Awake()
	{

	}

	void Start () 
	{
		dimensions = new Vector2(3,5);
		Build(dimensions);
	}

	void Build(Vector2 dimensions)
	{
		Tile tile;
		//float width = Screen.width / dimensions.x;

		int y,x;

		for(y=1; y<= dimensions.y; y++)
		{
			for(x=1; x<= dimensions.x; x++)
			{
				tile = ((GameObject)Instantiate(tilePrefab)).GetComponent<Tile>();
				tile.Init(new Vector2(x,y),tileType.stone);
			}
		}
	}

}
