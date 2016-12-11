using UnityEngine;

public class Gate : MonoBehaviour
{

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
        var state = GameManager.Instance.GameState;

        switch (state)
        {
            case GameState.LEVEL_ENDED:
                
            default:
                return;
        }
    }
}
