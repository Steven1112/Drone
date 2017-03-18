using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationManager : MonoBehaviour {

	public Animator card;
	public Animator email;
	public Animator board;
	public Animator monitor;
	public Animator strikeA;
	public Animator strikeB;
	public Animator strikeC;
	public Animator map;

	public GameObject missionOpen;
	public GameObject emailOpen;
	public GameObject boardZoom;
	public GameObject monitorZoom;
	public GameObject mapZoom;
	public GameObject introEmailButton;
	public GameObject introEmail;
	public GameObject evaluateEmailButton;
	public GameObject evaluateEmail;

	private int cardState;
	private int emailState;
	private int boardState;
	private int monitorState;
	private int strikeAState;
	private int strikeBState;
	private int strikeCState;
	private int mapState;
	private int introEmailButtonState;
	private int evaluateEmailButtonState;

	public GameObject StrikeA;
	public GameObject StrikeB;
	public GameObject StrikeC;
	public GameObject StrikeAStart;
	public GameObject StrikeBStart;
	public GameObject StrikeCStart;

	// Use this for initialization
	void Start () {

		missionOpen = GameObject.Find ("Card");
		emailOpen = GameObject.Find ("Email");
		boardZoom =  GameObject.Find ("Board");
		monitorZoom = GameObject.Find ("MonitorBottom");
		mapZoom = GameObject.Find ("Map");
		StrikeA = GameObject.Find ("StrikeA");
		StrikeB = GameObject.Find ("StrikeB");
		StrikeC = GameObject.Find ("StrikeC");
		StrikeAStart = GameObject.Find ("StrikeAStart");
		StrikeBStart = GameObject.Find ("StrikeBStart");
		StrikeCStart = GameObject.Find ("StrikeCStart");
		introEmailButton = GameObject.Find ("IntroEmailButton");
		introEmail = GameObject.Find ("IntroEmail");
		evaluateEmailButton = GameObject.Find ("EvaluateEmailButton");
		evaluateEmail = GameObject.Find ("EvaluateEmail");

		card = missionOpen.GetComponent<Animator>();
		email = emailOpen.GetComponent<Animator>();
		board = boardZoom.GetComponent<Animator>();
		monitor = monitor.GetComponent<Animator>();
		strikeA = StrikeA.GetComponent<Animator>();
		strikeB = StrikeB.GetComponent<Animator>();
		strikeC = StrikeC.GetComponent<Animator>();
		map = mapZoom.GetComponent<Animator>();

		StrikeA.SetActive (false);
		StrikeB.SetActive (false);
		StrikeC.SetActive (false);
		StrikeAStart.SetActive (false);
		StrikeBStart.SetActive (false);
		StrikeCStart.SetActive (false);
		missionOpen.SetActive (false);
		emailOpen.SetActive (false);
		introEmailButton.SetActive (false);
		introEmail.SetActive (false);
		evaluateEmailButton.SetActive (false);
		evaluateEmail.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void CardPopupPlay(){

		switch (cardState)
		{
		case 0:
			card.Play ("CardPopup");
			cardState = 1;
			StartCoroutine (WaitAnimationStart ());
			email.transform.SetAsFirstSibling();
			break;

		case 1:
			card.Play ("CardClosed");
			cardState = 0;
			StartCoroutine(WaitAnimationClose());
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void EmailPopupPlay(){

		switch (emailState)
		{
		case 0:
			email.Play ("EmailPopup");
			emailState = 1;
			email.transform.SetAsLastSibling();
			StartCoroutine (WaitEmailAnimationStart ());
			break;

		case 1:
			email.Play ("EmailClosed");
			emailState = 0;
			introEmailButton.SetActive (false);
			StartCoroutine(WaitEmailAnimationClose());
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void EmailScene3PopupPlay(){

		switch (emailState)
		{
		case 0:
			email.Play ("EmailPopup");
			emailState = 1;
			email.transform.SetAsLastSibling();
			StartCoroutine (WaitEmailScene3AnimationStart ());
			break;

		case 1:
			email.Play ("EmailClosed");
			emailState = 0;
			introEmailButton.SetActive (false);
			evaluateEmailButton.SetActive (false);
			StartCoroutine(WaitEmailAnimationClose());
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void BoardPopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			break;

		case 1:
			board.Play ("BoardZoomOut");
			boardState = 0;
			break;

		default:
			break;

		}
	}

	public void MapPopupPlay(){

		switch (mapState)
		{
		case 0:
			map.Play ("MapZoomIn");
			mapState = 1;
			mapZoom.transform.SetAsLastSibling();
			break;

		case 1:
			map.Play ("MapZoomOut");
			mapState = 0;
			break;

		default:
			break;

		}
	}

	public void MonitorPopupPlay(){

		switch (monitorState)
		{
		case 0:
			monitor.Play ("MonitorZoomIn");
			monitorZoom.transform.SetAsLastSibling();
			monitorState = 1;
			missionOpen.SetActive (true);
			emailOpen.SetActive (true);
			break;

		case 1:
			monitor.Play ("MonitorZoomOut");
			monitorState = 0;
			missionOpen.SetActive (false);
			emailOpen.SetActive (false);
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			introEmailButton.SetActive (false);
			introEmail.SetActive (false);
			evaluateEmailButton.SetActive (false);
			evaluateEmail.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void InfoAPopupPlay(){

		switch (strikeAState)
		{
		case 0:
			strikeA.Play ("InfoAZoomIn");
			strikeAState = 1;
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			StartCoroutine(WaitStrikeAStart());
			break;

		case 1:
			strikeA.Play ("InfoAZoomOut");
			strikeAState = 0;
			StrikeB.SetActive (true);
			StrikeC.SetActive (true);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			//StartCoroutine(WaitStrikeAClose());
			break;

		default:
			break;

		}
	}

	public void InfoBPopupPlay(){

		switch (strikeBState)
		{
		case 0:
			strikeB.Play ("InfoBZoomIn");
			strikeBState = 1;
			StrikeA.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeCStart.SetActive (false);
			StartCoroutine(WaitStrikeBStart());
			break;

		case 1:
			strikeB.Play ("InfoBZoomOut");
			strikeBState = 0;
			StrikeA.SetActive (true);
			StrikeC.SetActive (true);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			//StartCoroutine(WaitStrikeBClose());
			break;

		default:
			break;

		}
	}

	public void InfoCPopupPlay(){

		switch (strikeCState)
		{
		case 0:
			strikeC.Play ("InfoCZoomIn");
			strikeCState = 1;
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StartCoroutine(WaitStrikeCStart());
			break;

		case 1:
			strikeC.Play ("InfoCZoomOut");
			strikeCState = 0;
			StrikeA.SetActive (true);
			StrikeB.SetActive (true);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			//StartCoroutine(WaitStrikeCClose());
			break;

		default:
			break;

		}
	}

	public void InfoEmailPopupPlay(){

		switch (introEmailButtonState)
		{
		case 0:
			introEmailButtonState = 1;
			introEmail.SetActive (true);
			break;

		case 1:
			introEmailButtonState = 0;
			introEmail.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void EvaluateEmailPopupPlay(){

		switch (evaluateEmailButtonState)
		{
		case 0:
			evaluateEmailButtonState = 1;
			evaluateEmail.SetActive (true);
			break;

		case 1:
			evaluateEmailButtonState = 0;
			evaluateEmail.SetActive (false);
			break;

		default:
			break;

		}
	}

	IEnumerator WaitAnimationStart(){
		yield return new WaitForSeconds(1);
		StrikeA.SetActive (true);
		StrikeB.SetActive (true);
		StrikeC.SetActive (true);
	}

	IEnumerator WaitEmailAnimationStart(){
		yield return new WaitForSeconds (1);
		introEmailButton.transform.SetAsLastSibling();
		introEmailButton.SetActive (true);
	}

	IEnumerator WaitEmailScene3AnimationStart(){
		yield return new WaitForSeconds (1);
		introEmailButton.transform.SetAsLastSibling();
		introEmailButton.SetActive (true);
		evaluateEmailButton.transform.SetAsLastSibling();
		evaluateEmailButton.SetActive (true);
	}


	IEnumerator WaitAnimationClose(){
		yield return new WaitForSeconds(1);
	}

	IEnumerator WaitEmailAnimationClose(){
		yield return new WaitForSeconds(1);
		email.transform.SetAsFirstSibling();
	}

	IEnumerator WaitStrikeAStart(){
		yield return new WaitForSeconds(0.5f);
		StrikeAStart.SetActive (true);
	}

	IEnumerator WaitStrikeAClose(){
		yield return new WaitForSeconds(0.5f);
		StrikeAStart.SetActive (false);
	}

	IEnumerator WaitStrikeBStart(){
		yield return new WaitForSeconds(0.5f);
		StrikeBStart.SetActive (true);
	}

	IEnumerator WaitStrikeBClose(){
		yield return new WaitForSeconds(0.5f);
		StrikeBStart.SetActive (false);
	}

	IEnumerator WaitStrikeCStart(){
		yield return new WaitForSeconds(0.5f);
		StrikeCStart.SetActive (true);
	}

	IEnumerator WaitStrikeCClose(){
		yield return new WaitForSeconds(0.5f);
		StrikeCStart.SetActive (false);
	}
}


