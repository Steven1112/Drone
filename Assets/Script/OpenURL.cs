﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour {

	public string webLinkName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ActiveURL(){
		Application.OpenURL(webLinkName);
	}
}
