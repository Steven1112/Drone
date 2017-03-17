using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseEventController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	public Image description;

	// Use this for initialization
	void Start () {
		description.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerEnter(PointerEventData pointerEvent) {
		description.enabled = true;
	}

	public void OnPointerExit(PointerEventData pointerEvent) {
		description.enabled = false;
	}
}
