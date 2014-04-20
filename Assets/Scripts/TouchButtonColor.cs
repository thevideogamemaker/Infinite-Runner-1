using UnityEngine;
using System.Collections;

public class TouchButtonColor : TouchButtonLogic {

	void OnTouchBegan()
	{
		Camera.main.backgroundColor = Color.black;
	}
	
	void NewHampshire()
	{
		Camera.main.backgroundColor = Color.green;
	}

}
