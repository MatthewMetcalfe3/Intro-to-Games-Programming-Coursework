using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public GameObject gun;
	public int score = 0;
	public int buttonWidth =100;
	public int buttonHeight = 30;
	public int buttonYPosition = 300;
		IEnumerator PlayButtonClick()
	{
		audio.Play();
		yield return new WaitForSeconds(audio.clip.length);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
		if(gun.active)
		{
			if (Input.GetButtonDown("Fire1")){	
				gun.audio.Play(); 
				Ray ray = Camera.main.ScreenPointToRay
										(Input.mousePosition);
				RaycastHit hit=new RaycastHit();
					if (Physics.Raycast(ray,out hit))
					{
				
						if (hit.collider.gameObject.tag=="Target") 
						{
							Debug.Log("Hit the barrel");
							TargetScript TargetScript=hit.collider.gameObject.GetComponent<TargetScript>();
						if (TargetScript!=null)
						{
							TargetScript.Hit();
						}

						score ++;
						}
					
					}
			}
		
		}
		
	}
	void OnGUI()
	{
			GameObject gameData=GameObject.Find("GameData");
	if (gameData!=null){
		GameDataScript gameDataScript=gameData.GetComponent<GameDataScript>();
	GUI.Label(new Rect(10,10,100,40),gameDataScript.playerName+" Score:"+score.ToString());	
			
	
	
	}
	
//quit button
	if (GUI.Button(new Rect(Screen.width-buttonWidth,Screen.height-buttonHeight,buttonWidth,buttonHeight), "Quit"))
	{		
			StartCoroutine(PlayButtonClick());// plays the audio
		//quit the game
		Application.LoadLevel("EndScene");
	}	
		



	}
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.name=="machineGun")
		{Debug.Log("object picked up" + hit.gameObject.name);
			Destroy(hit.gameObject);
			gun.active=true;
		}
		if (hit.gameObject.name=="Teleport") 
		{
			Debug.Log("hitTeleport");
			Application.LoadLevel("Level2");
		}
		if (hit.gameObject.name=="Teleport2") 
		{
			Debug.Log("hitTeleport");
			Application.LoadLevel("fps");
		}
	}
}
