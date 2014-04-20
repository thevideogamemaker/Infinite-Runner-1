using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour 
{
	
	void Update () 
	{
		//is there a touch on screen?
		if(Input.touches.Length <= 0)
		{
			//if no touches execute this code
		}
		else
		{
			//loop through all the touches on scren
			for(int i = 0; i < Input.touchCount; i++)
			{
				// execute this code for current touch (i) on screen
				if(this.guiTexture.HitTest(Input.GetTouch(i).position))
				{
					//if current touch hits our gui texture, run this code
					if(Input.GetTouch(i).phase == TouchPhase.Began)
					{
						this.SendMessage("OnTouchBegan");
						//OnTouchBegan();
						//Debug.Log ("The touch has began");
					}
					if(Input.GetTouch(i).phase == TouchPhase.Ended)
					{
						this.SendMessage("OnTouchEnded");
						//Debug.Log ("The touch has ended");
					}
				}
			}
		}
	}
}
