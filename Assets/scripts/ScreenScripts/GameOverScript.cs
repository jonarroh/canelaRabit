using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
	public void Start()
	{
		SceneManager.LoadScene("Start");
	}

	public void Exit()
	{
		Application.Quit();
	}
}
