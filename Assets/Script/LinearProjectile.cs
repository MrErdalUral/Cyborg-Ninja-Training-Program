using UnityEngine;

public class LinearProjectile : Projectile
{
    public float Speed;

    private Vector2 _movementVector;

    private Rigidbody2D _rigidBody;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        var gameState = GameManager.Instance.GameState;

        switch (gameState)
        {
            case GameState.PLAYING:
                _rigidBody.velocity = _movementVector * Speed;
                break;
            default:
                break;
        }
    }

    public override void SetTarget(Transform target)
    {
        Target = target;
        _movementVector = (Target.position - transform.position).normalized;
    }
}
