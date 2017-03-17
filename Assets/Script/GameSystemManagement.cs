using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystemManagement : MonoBehaviour {
	private int kills = 0;

	// Use this for initialization
	void Start () {
		
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
