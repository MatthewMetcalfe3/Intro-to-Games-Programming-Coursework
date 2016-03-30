using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour 
{
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
		int buttonYPosition=buttonYStart;
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backGroundTexture);
		
   		GUI.Label(new Rect(Screen.width/2-100.0f,50.0f,100.0f,20.0f),("The end... "));  
		          
		//quit button
			if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,buttonYPosition,buttonWidth,buttonHeight), "Quit"))
			{
				StartCoroutine(PlayButtonClick());//plays the audio
			
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

