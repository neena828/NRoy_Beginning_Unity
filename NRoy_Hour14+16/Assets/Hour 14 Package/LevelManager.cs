﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad;


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
