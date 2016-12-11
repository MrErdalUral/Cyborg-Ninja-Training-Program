using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public GameState GameState;

	public Transform DoorLeft;

	public Transform DoorRight;

	public Transform Prof;

	private bool _loading = false;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		DontDestroyOnLoad(this);

		if (Instance != this)
		{
			Destroy(Instance);
		}
		Instance = this;
		//GameState = GameState.LEVEL_START;
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (GameState)
		{
			case GameState.MENU:
				break;
				
			case GameState.LEVEL_START:
				break;

			case GameState.INIT_NEXT_LEVEL:
				RandomizeLevel();
				break;

			case GameState.PLAYING:
				break;

			case GameState.PAUSED:
				break;

			case GameState.DEAD:
				break;

			default:
				return;
		}
	}

	void RandomizeLevel()
	{
		if (!_loading)
		{
			_loading = true;
			Debug.Log("Randomizing level...");
			
			// var level = int.Parse(SceneManager.GetActiveScene().name.Substring(5)); // "scene1" -> 1
			// var nextLevelName = string.Format("scene{0}", (level + 1));

			// Debug.Log(_levelCount);
			// Debug.Log("sceneCount: " + SceneManager.sceneCount);
			// if (_levelCount == level)
			// {
			// 	return;
			// }

			// SceneManager.LoadScene(nextLevelName);
		
			DoorLeft.position = new Vector3(-4.5f, 6, 0);
			DoorRight.position = new Vector3(4.5f, 6, 0);			
			Prof.position = new Vector3(0, 7.5f, 0);

			GameState = GameState.LEVEL_START;
			_loading = false;
		}
	}
}
