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
        _animator.ResetTrigger("LevelEnd");
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        var gameState = GameManager.Instance.GameState;
        if (gameState == GameState.LEVEL_ENDED)
        {
            _animator.SetTrigger("LevelEnd");
        }
    }
}
