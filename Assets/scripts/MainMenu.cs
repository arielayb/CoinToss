using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Button startGame;
	public Button quitGame;

	// Use this for initialization
	void Start () 
	{
		Button btn  = startGame.GetComponent<Button>();
		//Button btn2 = quitGame.GetComponent<Button>();

		btn.onClick.AddListener(StartGame);
		//btn2.onClick.AddListener(QuitGame);	
	}

	// Update is called once per frame
	void Update () 
	{
		//AA: exit application using the back button on android
		if (Input.GetKey("escape"))
			Application.Quit();
	}

	void StartGame()
	{
		SceneManager.LoadScene("flipIt");
	}

	void QuitGame()
	{
//		if (Input.GetKey(KeyCode.Escape))
//		{
//			if (Application.platform == RuntimePlatform.Android)
//			{
//				Application.Quit();
//			}
//		}
	}
}
