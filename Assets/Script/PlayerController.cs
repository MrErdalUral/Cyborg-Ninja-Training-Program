﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D _rigidbody;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (GameManager.Instance.GameState != GameState.PLAYING) return;
        var movingVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        _rigidbody.velocity = movingVector * Speed;

    }
}
