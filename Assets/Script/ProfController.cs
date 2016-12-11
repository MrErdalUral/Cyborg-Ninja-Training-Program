using UnityEngine;

public class ProfController : MonoBehaviour
{
    private Animator _animator;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        DontDestroyOnLoad(this);
        
        _animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        var gameState = GameManager.Instance.GameState;
        switch (gameState)
        {
            case GameState.LEVEL_ENDED:
                _animator.SetTrigger("EnterRoom");
                break;

            // case GameState.LEVEL_START:
            //     _animator.SetTrigger("ExitRoom");
            //     break;

            default:
                break;
        }
    }
}
