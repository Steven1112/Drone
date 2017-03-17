using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollisionController : MonoBehaviour {
	public Transform readyBar;

	public float speed;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * Time.deltaTime * speed);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "StrikePoints") {
			Debug.Log ("Hit");
			Destroy (gameObject, 0.2f);
			Destroy (collider.gameObject, 0.2f);
		}
	}
}
