using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public GameState GameState;

	private bool _loading = false;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		if (Instance != this)
		{
			Destroy(Instance);
		}
		Instance = this;
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
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);

			GameState = GameState.LEVEL_START;
			_loading = false;
		}
	}
}
