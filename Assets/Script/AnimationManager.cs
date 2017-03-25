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
	public Animator scoreBoard;
	public Animator newsBoard;

	public GameObject missionOpen;
	public GameObject emailOpen;
	public GameObject boardZoom;
	public GameObject monitorZoom;
	public GameObject mapZoom;
	public GameObject introEmailButton;
	public GameObject introEmail;
	public GameObject evaluateEmailButton;
	public GameObject evaluateEmail;
	public GameObject closeEmailButton;
	public GameObject closeTaskButton;
	public GameObject scoreButton;
	public GameObject newsButton;
	//public GameObject resignImage;

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
	private int scoreState;
	private int newsState;

	public GameObject StrikeA;
	public GameObject StrikeB;
	public GameObject StrikeC;
	public GameObject StrikeAStart;
	public GameObject StrikeBStart;
	public GameObject StrikeCStart;
	public GameObject weblinkButton;

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
		closeEmailButton = GameObject.Find ("EmailCloseButton");
		closeTaskButton = GameObject.Find ("TaskCloseButton");
		weblinkButton = GameObject.Find ("WeblinkButton");
		scoreButton = GameObject.Find ("ScoreButton");
		newsButton = GameObject.Find ("NewsButton");
		//resignImage = GameObject.Find ("ResignImage");

		card = missionOpen.GetComponent<Animator>();
		email = emailOpen.GetComponent<Animator>();
		board = boardZoom.GetComponent<Animator>();
		monitor = monitor.GetComponent<Animator>();
		strikeA = StrikeA.GetComponent<Animator>();
		strikeB = StrikeB.GetComponent<Animator>();
		strikeC = StrikeC.GetComponent<Animator>();
		map = mapZoom.GetComponent<Animator>();
		scoreBoard = scoreButton.GetComponent<Animator>();
		newsBoard = newsButton.GetComponent<Animator>();

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
		closeEmailButton.SetActive (false);
		closeTaskButton.SetActive (false);
		weblinkButton.SetActive (false);
		scoreButton.SetActive (false);
		newsButton.SetActive (false);
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
			StartCoroutine (WaitAnimationClose ());
			StrikeA.SetActive (false);
			StrikeB.SetActive (false);
			StrikeC.SetActive (false);
			StrikeAStart.SetActive (false);
			StrikeBStart.SetActive (false);
			StrikeCStart.SetActive (false);
			closeTaskButton.SetActive (false);
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
			closeEmailButton.SetActive (false);
			closeTaskButton.SetActive (false);
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
			closeEmailButton.SetActive (false);
			closeTaskButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void BoardPopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardIntialZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			break;

		case 1:
			board.Play ("BoardIntialZoomOut");
			boardState = 0;
			break;

		default:
			break;

		}
	}

	public void BoardScene2PopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			scoreButton.transform.SetAsLastSibling();
			newsButton.transform.SetAsLastSibling();
			scoreButton.SetActive (true);
			newsButton.SetActive (true);
			StartCoroutine(WaitBoardPopup());
			break;

		case 1:
			board.Play ("BoardZoomOut");
			boardState = 0;
			scoreButton.SetActive (false);
			newsButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void BoardScene3PopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardBZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			scoreButton.transform.SetAsLastSibling();
			newsButton.transform.SetAsLastSibling();
			scoreButton.SetActive (true);
			newsButton.SetActive (true);
			StartCoroutine(WaitBoardPopup());
			break;

		case 1:
			board.Play ("BoardBZoomOut");
			boardState = 0;
			scoreButton.SetActive (false);
			newsButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void BoardScene2CPopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardCZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			scoreButton.transform.SetAsLastSibling();
			newsButton.transform.SetAsLastSibling();
			scoreButton.SetActive (true);
			newsButton.SetActive (true);
			StartCoroutine(WaitBoardPopup());
			break;

		case 1:
			board.Play ("BoardCZoomOut");
			boardState = 0;
			scoreButton.SetActive (false);
			newsButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void BoardResignCPopupPlay(){

		switch (boardState)
		{
		case 0:
			board.Play ("BoardResignZoomIn");
			boardState = 1;
			boardZoom.transform.SetAsLastSibling();
			newsButton.transform.SetAsLastSibling();
			newsButton.SetActive (true);
			StartCoroutine(WaitBoardPopup());
			break;

		case 1:
			board.Play ("BoardResignZoomOut");
			boardState = 0;
			newsButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void ScorePopupPlay(){

		switch (scoreState)
		{
		case 0:
			scoreBoard.Play ("ScoreZoomIn");
			scoreButton.transform.SetAsLastSibling();
			scoreState = 1;
			break;

		case 1:
			scoreBoard.Play ("ScoreZoomOut");
			scoreState = 0;
			break;

		default:
			break;

		}
	}

	public void ScoreScene3PopupPlay(){

		switch (scoreState)
		{
		case 0:
			scoreBoard.Play ("ScoreBZoomIn");
			scoreButton.transform.SetAsLastSibling();
			scoreState = 1;
			break;

		case 1:
			scoreBoard.Play ("ScoreBZoomOut");
			scoreState = 0;
			break;

		default:
			break;

		}
	}

	public void ScoreScene2CPopupPlay(){

		switch (scoreState)
		{
		case 0:
			scoreBoard.Play ("Score2CZoomIn");
			scoreButton.transform.SetAsLastSibling();
			scoreState = 1;
			break;

		case 1:
			scoreBoard.Play ("Score2CZoomOut");
			scoreState = 0;
			break;

		default:
			break;

		}
	}

	public void NewsPopupPlay(){

		switch (newsState)
		{
		case 0:
			newsBoard.Play ("NewsZoomIn");
			newsButton.transform.SetAsLastSibling();
			newsState = 1;
			break;

		case 1:
			newsBoard.Play ("NewsZoomOut");
			newsState = 0;
			break;

		default:
			break;

		}
	}

	public void NewsScene3PopupPlay(){

		switch (newsState)
		{
		case 0:
			newsBoard.Play ("NewsBZoomIn");
			newsButton.transform.SetAsLastSibling();
			newsState = 1;
			break;

		case 1:
			newsBoard.Play ("NewsBZoomOut");
			newsState = 0;
			break;

		default:
			break;

		}
	}

	public void NewsScene2CPopupPlay(){

		switch (newsState)
		{
		case 0:
			newsBoard.Play ("News2CZoomIn");
			newsButton.transform.SetAsLastSibling();
			newsState = 1;
			break;

		case 1:
			newsBoard.Play ("News2CZoomOut");
			newsState = 0;
			break;

		default:
			break;

		}
	}

	public void ResignPopupPlay(){

		switch (newsState)
		{
		case 0:
			newsBoard.Play ("ResignZoomIn");
			newsButton.transform.SetAsLastSibling ();
			newsState = 1;
			//resignImage.SetActive (false);
			break;

		case 1:
			newsBoard.Play ("ResignZoomOut");
			newsState = 0;
			//StartCoroutine(WaitResignClose());
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
			closeEmailButton.SetActive (false);
			closeTaskButton.SetActive (false);
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
			//closeEmailButton.SetActive (true);
			//closeEmailButton.transform.SetAsLastSibling();
			break;

		case 1:
			introEmailButtonState = 0;
			introEmail.SetActive (false);
			//closeEmailButton.SetActive (false);
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
			weblinkButton.SetActive (true);
			//closeEmailButton.SetActive (true);
			//closeEmailButton.transform.SetAsLastSibling();
			break;

		case 1:
			evaluateEmailButtonState = 0;
			evaluateEmail.SetActive (false);
			weblinkButton.SetActive (false);
			//closeEmailButton.SetActive (false);
			break;

		default:
			break;

		}
	}

	public void CloseEmailPopupPlay(){
		introEmail.SetActive (false);
		evaluateEmail.SetActive (false);
		closeEmailButton.SetActive (false);
		closeTaskButton.SetActive (false);
		weblinkButton.SetActive (false);

		email.Play ("EmailClosed");
		emailState = 0;
		introEmailButton.SetActive (false);
		evaluateEmailButton.SetActive (false);
		weblinkButton.SetActive (false);
	}

	public void CloseTaskPopupPlay(){
		closeTaskButton.SetActive (false);

		card.Play ("CardClosed");
		cardState = 0;
		StrikeA.SetActive (false);
		StrikeB.SetActive (false);
		StrikeC.SetActive (false);
		StrikeAStart.SetActive (false);
		StrikeBStart.SetActive (false);
		StrikeCStart.SetActive (false);
	}

	IEnumerator WaitAnimationStart(){
		yield return new WaitForSeconds(1);
		StrikeA.SetActive (true);
		StrikeB.SetActive (true);
		StrikeC.SetActive (true);
		closeTaskButton.SetActive (true);
		closeTaskButton.transform.SetAsLastSibling();
	}

	IEnumerator WaitEmailAnimationStart(){
		yield return new WaitForSeconds (1);
		introEmailButton.transform.SetAsLastSibling();
		introEmailButton.SetActive (true);
		closeEmailButton.SetActive (true);
		closeEmailButton.transform.SetAsLastSibling();
	}

	IEnumerator WaitEmailScene3AnimationStart(){
		yield return new WaitForSeconds (1);
		introEmailButton.transform.SetAsLastSibling();
		introEmailButton.SetActive (true);
		evaluateEmailButton.transform.SetAsLastSibling();
		evaluateEmailButton.SetActive (true);
		closeEmailButton.SetActive (true);
		closeEmailButton.transform.SetAsLastSibling();
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

	IEnumerator WaitBoardPopup(){
		yield return new WaitForSeconds(1);
	}

	/*
	IEnumerator WaitResignClose(){
		yield return new WaitForSeconds(0.5f);
		resignImage.SetActive (false);
	}
	*/

}


