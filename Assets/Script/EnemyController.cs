using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyState _state;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        _state = EnemyState.ALIVE;
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

        switch (_state)
        {
            
            default:
                break;
        }
    }
}