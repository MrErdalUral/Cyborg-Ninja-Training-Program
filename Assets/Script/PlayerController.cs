using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if (GameManager.Instance.GameState != GameState.PLAYING) return;
        var mousePosition = Input.mousePosition;
        transform.localScale = new Vector3(Mathf.Sign(mousePosition.x - transform.position.x), 1, 1);
        Debug.logger.Log(LogType.Error,mousePosition);
        var movingVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        _animator.SetBool("Running", movingVector != Vector2.zero);
        _rigidbody.velocity = movingVector * Speed;

    }
}
