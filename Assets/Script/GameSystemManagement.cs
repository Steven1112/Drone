using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManagement : MonoBehaviour {
	public int kills = 0;

	public static GameSystemManagement instance = null;

	// Use this for initialization
	void Start () {
		
		// create instance
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddKills(int kills) {
		this.kills += kills;
	}

	public int GetKills() {
		return this.kills;
	}
}
