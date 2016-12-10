using UnityEngine;

public class HomingProjectile : MonoBehaviour, IProjectile
{
    public float Speed;

    public GameObject Target;

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
                var movement = (Target.transform.position - transform.position);
                _rigidBody.velocity = movement.normalized * Speed;
                break;
            default:
                break;
        }
    }
}
