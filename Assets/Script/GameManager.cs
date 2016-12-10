using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameState _gameState = GameState.MENU;

	public static GameManager Instance;

	void Awake()
	{
		if (Instance != this)
		{
			DestroyInstance(this);
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
		switch (switch_on)
		{
			
			default:
		}
	}
}
