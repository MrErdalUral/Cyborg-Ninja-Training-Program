﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private Weapon _weapon;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _weapon = GetComponentInChildren<Weapon>();
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (GameManager.Instance.GameState != GameState.PLAYING) return;
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.localScale = new Vector3(Mathf.Sign(mousePosition.x - transform.position.x), 1, 1);
        var movingVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        if(Mathf.Sign(mousePosition.x - transform.position.x) >0)
            _weapon.SwitchDirection = true;
        else
            _weapon.SwitchDirection = false;

        _animator.SetBool("Running", movingVector != Vector2.zero);
        _rigidbody.velocity = movingVector * Speed;

    }
}
