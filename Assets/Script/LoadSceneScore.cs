using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScore : MonoBehaviour {

	public string highScoreSceneName;
	public string mediumScoreSceneName;
	public string lowScoreSceneName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void CheckLoadScene(){
		
		if (GameSystemManagement.instance.GetKills() < 200) {
			SceneManager.LoadScene(lowScoreSceneName);
		}
			
		if (GameSystemManagement.instance.GetKills() > 200 && GameSystemManagement.instance.GetKills() < 400) {
			SceneManager.LoadScene(mediumScoreSceneName);
		}

		if (GameSystemManagement.instance.GetKills() > 400) {
			SceneManager.LoadScene(highScoreSceneName);
		}

	}
}
