using UnityEngine;

public class StationaryEnemyController : MonoBehaviour
{
    public EnemyState State;

    public Transform Target;
    public GameObject ProjectilePrefab;
    
    public float Cooldown = 2.0f;

    public float RandomWaitTime = 0.0f;

    private float _currentRandomWaitTime;

    private float _lastShotTime;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
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
                break;

            case EnemyState.ALIVE:
                if (Time.time > _lastShotTime + Cooldown + _currentRandomWaitTime)
                {
                    Shoot();
                }
                break;
        }
    }

    void Shoot()
    {
        if (Target == null) return;
        _lastShotTime = Time.time;
        _currentRandomWaitTime = Random.value * RandomWaitTime;
        var instance = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);
        instance.transform.SetParent(transform);
        var projectile = instance.GetComponent<Projectile>();
        projectile.Owner = gameObject;
        projectile.SetTarget(Target);
    }
}
