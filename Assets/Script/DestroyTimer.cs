using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float Timeout;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        Destroy(gameObject, Timeout);
    }
}
