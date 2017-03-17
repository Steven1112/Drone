using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public string LoadSceneName;
	public CheckResignTimes checkResignTimes;

	void Start()
	{

	}

	// load scenes construster, change scene name string in the front end
	public void LoadSceneMethod()
	{
		SceneManager.LoadScene(LoadSceneName);

	}

	//when press the resign button
	public void Resign()
	{
		SceneManager.LoadScene(LoadSceneName);
		CheckResignTimes.resignButtonUsedTimes ++;
		CheckResignTimes.instance.resignButton.SetActive (false);
	}
}
