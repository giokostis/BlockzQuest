using UnityEngine;
using System.Collections;

public class Dimm : MonoBehaviour {
	
	public SpriteRenderer sprite;
	public Animator anim;

	void Awake ()
	{
		transform.localScale = new Vector3((Screen.width+20)/4f,(Screen.height+20)/4f); // 4px is the acuall size of the Dimm graphic
		sprite.enabled = true;
		Game.Manager.dimm = this;
	}


	public void StartDimm()
	{
		anim.SetBool("Dimm",true);
	}

	public void Stop()
	{
		anim.SetBool("Dimm",false);
	}

	public void DimmDone()
	{
		//Debug.Log("Black");
	}

	public void Vanished()
	{
		// TODO beautyfull transition between scenes here
		//Debug.Log("Vanished");
	}
	
}
