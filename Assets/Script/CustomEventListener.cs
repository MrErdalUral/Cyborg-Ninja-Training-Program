using UnityEngine;

public class CustomEventListener : MonoBehaviour
{
    public void ProfEnterEndEvent()
    {
        if (GameManager.Instance.GameState == GameState.LEVEL_ENDED)
        {
            GameManager.Instance.GameState = GameState.INIT_NEXT_LEVEL;
        }
    }

    public void PlayerDieEndEvent()
    {
        if (GameManager.Instance.GameState == GameState.PLAYING)
        {
            GameManager.Instance.GameState = GameState.LEVEL_ENDED;
        }
    }
}
