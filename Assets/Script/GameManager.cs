using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameManager Instance;

	private GameState _gameState = GameState.MENU;

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
		switch (_gameState)
		{
			case GameState.MENU:

			case GameState.LEVEL_START:

			case GameState.LEVEL_ENDED:

			case GameState.PLAYING:

			case GameState.PAUSED:

			case GameState.DEAD:

			default:
				return;
		}
	}
}
