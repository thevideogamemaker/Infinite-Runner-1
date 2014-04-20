using UnityEngine;
using System.Collections;

public class TouchButtonTalk : TouchButtonLogic {

	void OnTouchBegan()
	{
		Debug.Log ("The mouse is down" + this.name);
	}
	
	void OnTouchEnded()
	{
		Debug.Log ("The touch has ended" + this.name);
	}

}
