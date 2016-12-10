using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	public GameState GameState;

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
		GameState = GameState.MENU;
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
