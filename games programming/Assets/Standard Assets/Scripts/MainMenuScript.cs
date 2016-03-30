using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	public Texture2D backGroundTexture;
	public int buttonWidth =100;
	public int buttonHeight = 30;
	public int buttonSpacing = 70;
	public int buttonYStart = 300;
	
	
		IEnumerator PlayButtonClick()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}	
	void OnGUI()
	{

	//splash screen
	GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backGroundTexture);
		



	// start button	
	int buttonYPosition=buttonYStart;	
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,buttonYPosition,buttonWidth,buttonHeight), "Start"))
		{
			StartCoroutine(PlayButtonClick());// plays the audio
			//load level
			Application.LoadLevel("fps");
		}
		buttonYPosition+=buttonSpacing;
	// options button
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,buttonYPosition,buttonWidth,buttonHeight), "Options"))
		{
			StartCoroutine(PlayButtonClick());// plays the audio
			//load level
			Application.LoadLevel("Options");
		}
			
	buttonYPosition+=buttonSpacing;
	//quit button
	if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,
			buttonYPosition,buttonWidth,buttonHeight), "Quit"))
	{
			StartCoroutine(PlayButtonClick());//plays the audio
			Application.LoadLevel("EndScene");
		//quit the game
		Application.Quit();
	}
	


	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
