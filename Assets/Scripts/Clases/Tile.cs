using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Vector2 cords;
	public tileType type;
	Animator anim;

	GameObject padlock;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	void Start()
	{
	}

	public void Init(Vector2 newCords, tileType newType)
	{
		cords = newCords;
		type = newType;

		anim.SetTrigger(type.ToString());
	}

	void OnMouseDown()
	{
		transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(0,0,10));
		print(Camera.main.WorldToScreenPoint(transform.localPosition));
	}
}
