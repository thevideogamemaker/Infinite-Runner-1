using UnityEngine;
using System.Collections;

public class MouseButton : MonoBehaviour 
{

	void Start ()
	{

	}

	void OnMouseDown()
	{
		Debug.Log ("The mouse is down");
	}
	
	void OnMouseUp()
	{
		Debug.Log ("The mouse is up");
	}

}
