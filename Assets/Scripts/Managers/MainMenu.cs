using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	/* lvlPrefab: The Prefab of the level object
	 * userLevel: The level that the user is currently on
	 * maxLevel: The maximum level supported in this world
	 * */

	public GameObject lvlPrefab;
	public int maxLevel = 15;
	public int userLevel = 12;
	public int collumns = 5;
	
	void Start () 
	{
		int i;
		float x = -1.8f;
		float y = 1f;
		for(i=0; i<userLevel + 1; i++) {

			if(i%5 == 0) {
				y-=0.6f;
				x=-1.8f;
			}
			x+=0.6f;
			GameObject newLevel = (GameObject)Instantiate(lvlPrefab, new Vector3 (x,y,0), Quaternion.identity);
			newLevel.transform.localScale = new Vector3(0.1f,0.1f,0.1f);



			//Next level is locked
			if(i!=userLevel) {
				newLevel.transform.FindChild("Lock").renderer.enabled = false;
				newLevel.transform.FindChild("num").GetComponent<TextMesh>().text = (i+1) + "";
			}

			print ("Created a level");
		}
	
	}


}