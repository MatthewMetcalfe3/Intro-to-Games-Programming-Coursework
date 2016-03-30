using UnityEngine;
using System.Collections;

public class OptionsScript : MonoBehaviour {
string nameText="";
	public Texture2D backGroundTexture;
		public int buttonWidth =100;
	public int buttonHeight = 30;
	public int buttonSpacing = 70;
	public int buttonYStart = 300;
	
	void OnGUI()
	{	
		//splash screen
	GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backGroundTexture);
	
	GUI.Label(new Rect(Screen.width/2-100.0f,10,100,40),("please enter your name"));	
	nameText=GUI.TextField(new Rect(Screen.width/2-100.0f,50.0f,100.0f,20.0f),nameText);
    GameObject GameData=GameObject.Find("GameData");
	if (GameData!=null){
		GameDataScript GameDataScript=GameData.GetComponent<GameDataScript>();
		GameDataScript.playerName=nameText;
		}
		// start button	
	int buttonYPosition=buttonYStart;	
		if (GUI.Button(new Rect(Screen.width/2-buttonWidth/2,buttonYPosition,buttonWidth,buttonHeight), "Back"))
		{
			StartCoroutine(PlayButtonClick());// plays the audio
			//load level
			Application.LoadLevel("MainMenu");
		}
	}
	
	IEnumerator PlayButtonClick()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
