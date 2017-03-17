using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikePointRandomizer : MonoBehaviour {
	public GameObject strikePointPrefab;


	// Use this for initialization
	void Start () {
		float leftEndX = -5.5f;
		for (int i = 0; i < 3; i++) {
			float rightEndX = leftEndX + 3f;
			float x = Random.Range (leftEndX, rightEndX);
			float y = Random.Range (0, 3f);

			Vector2 randomPoint = new Vector2 (x, y);
			GameObject strikePoint = (GameObject)Instantiate (strikePointPrefab, randomPoint, Quaternion.identity);
			leftEndX += 4f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
