using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	Vector2 cords;
	tileType type;
	Animator anim;

	GameObject padlock;

	void Awake()
	{
		anim = GetComponent<Animator>();
		print("I am awaken and I am a tile!!");
	}

	void Start()
	{
		print("I staerted and I am a tile!!");
	}

	public void Init(Vector2 newCords, tileType newType)
	{
		cords = newCords;
		type = newType;

		anim.SetTrigger(type.ToString());
	}

	void OnMouseDown()
	{
		print("My type is:"+type);
	}
}
