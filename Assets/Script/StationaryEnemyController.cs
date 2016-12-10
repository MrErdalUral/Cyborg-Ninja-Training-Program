using UnityEngine;

public class StationaryEnemyController : MonoBehaviour
{
    public EnemyState State;

    public GameObject Target;
    
    public float Cooldown = 2.0f;

    public float RandomWaitTime = 0.5f;

    private float _currentRandomWaitTime;

    private bool _canShoot;
    private float _lastShotTime;

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
        if (gameState != GameState.PLAYING) {
            return;
        }

        switch (State)
        {
            case EnemyState.DEAD:
            case EnemyState.STUNNED:
            default:
                return;

            case EnemyState.ALIVE:
                if (Time.time > _lastShotTime + Cooldown + _currentRandomWaitTime)
                {
                    Shoot();
                }
                return;
        }
    }

    void Shoot()
    {
        if (!_canShoot)
        {
            return;
        }

        _lastShotTime = Time.time;
        _currentRandomWaitTime = Random.value * RandomWaitTime;
    }
}
