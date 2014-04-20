using UnityEngine;
using System.Collections;

public class GameOverscript : MonoBehaviour {

	int score = 0;

	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");
	}
	
	void OnGUI ()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "Game Over");

		GUI.Label (new Rect (Screen.width / 2 - 40, 120, 80, 30), "Score: " + score);

		if(GUI.Button(new Rect(Screen.width / 2 - 40, 200, 65, 30), "Restart?"))
		{
			Application.LoadLevel(0);
		}
	}
}
