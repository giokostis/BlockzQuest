using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {


	public GameObject lvlPrefab;
	public int maxLevel = 12;
	public int collumns = 5;
	
	void Start () 
	{
		int i;
		float x = -2f;
		float y = 1f;
		for(i=0; i<maxLevel; i++) {

			if(i%5 == 0) {
				y-=0.6f;
				x=-1.8f;
			}
			x+=0.6f;
			GameObject newLevel = (GameObject)Instantiate(lvlPrefab, new Vector3 (x,y,0), Quaternion.identity);
			newLevel.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
			//((GameObject)Instantiate(lvlPrefab,lvlPos.transform.position,Quaternion.identity)).GetComponent<Lvl>();
			
			print ("Created a level");
		}
	
	}


}