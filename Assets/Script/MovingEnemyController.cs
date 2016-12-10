using UnityEngine;

public class MovingEnemyController : MonoBehaviour
{
    public EnemyState State;

    public GameObject Target;

    public float Speed;

    public float RotationSpeed;

    private Rigidbody2D _rigidBody; 

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        State = EnemyState.ALIVE;
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        var gameState = GameManager.Instance.GameState;
        if (gameState != GameState.PLAYING)
        {
            return;
        }

        switch (State)
        {
            case EnemyState.STUNNED:
                break;

            case EnemyState.DEAD:
                break;

            case EnemyState.ALIVE:
                var targetPosition = Target.transform.position;
                var position = transform.position;
                
                var x = 
                    (targetPosition.x < position.x) ? -1 :
                    (targetPosition.x > position.x) ? 1 :
                    0;

                var y =
                    (targetPosition.y < position.y) ? -1 :
                    (targetPosition.y > position.y) ? 1 :
                    0;  

                _rigidBody.velocity = new Vector2(x, y).normalized * Speed;

                break;

            default:
                break;
        }
    } 
}