using UnityEngine;

public class SlidingWall : MonoBehaviour
{
    private Animator _animator;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
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
            // case GameState.LEVEL_START:
            //     _animator.SetTrigger("Close");
            //     break;
                
            case GameState.LEVEL_ENDED:
                _animator.SetTrigger("Open");
                break;
        }
    }
}
