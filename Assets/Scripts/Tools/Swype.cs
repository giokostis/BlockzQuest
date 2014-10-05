using UnityEngine;
using System.Collections;

public class Swype : MonoBehaviour 
{
	Vector2 startPosition;
	float startTime;

	void LateUpdate () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			startPosition = Input.GetTouch(0).position;
			startTime = Time.time;
		}

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) 
		{
			Vector2 endPosition = Input.GetTouch(0).position;
			Vector2 delta = endPosition - startPosition;
			float dist = Mathf.Sqrt(Mathf.Pow(delta.x, 2) + Mathf.Pow (delta.y, 2));
			float angle = Mathf.Atan (delta.y/delta.x) * (180.0f/Mathf.PI);
			float duration = Time.time - startTime;
			float speed = dist/duration;

			if (angle < 0) angle = angle * -1.0f;

			if (dist > 30 && speed > 100) 
			{
				if((Mathf.Abs(startPosition.x - endPosition.x) >= Mathf.Abs(startPosition.y - endPosition.y)))
				{
					if (angle <= 45)
					{
						//  Left - Right
						if (startPosition.x < endPosition.x) 	Game.Manager.Swype(swype.right);
						else 									Game.Manager.Swype(swype.left);
					}
				}
				else 
				{
					if(angle >= 45)
					{
						// Up - Down
						if (startPosition.y < endPosition.y) 	Game.Manager.Swype(swype.up);
						else 									Game.Manager.Swype(swype.down);
					}
				}
			}
		}
	}
}
