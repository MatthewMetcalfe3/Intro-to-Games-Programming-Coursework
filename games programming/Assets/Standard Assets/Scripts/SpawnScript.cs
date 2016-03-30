using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public string playerName="";
	public GameObject spawnPrefab;
	
	// Use this for initialization
	void Start () {
	 DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Spawn()
	{
		 int count = 0;
		do 
		{
		GameObject barrel=(GameObject)Instantiate(spawnPrefab,
						transform.position,Quaternion.identity);
		barrel.name="barrel";	
			
			count ++;
		}
		while (count < 2);
}

}
