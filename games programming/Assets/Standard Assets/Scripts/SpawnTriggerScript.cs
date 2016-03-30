using UnityEngine;
using System.Collections;

public class SpawnTriggerScript : MonoBehaviour {
	public SpawnScript spawnScript;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name=="Player")
		{
			spawnScript.Spawn();
		}
	}

}


