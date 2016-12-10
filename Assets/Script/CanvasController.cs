using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public static CanvasController Instance;
    public float LightsOffSpeed = 1f;
    private Image _darknessPanel;

    // Use this for initialization
    void Awake()
    {
        if(Instance != this)
            Destroy(Instance);
        Instance = this;
        DontDestroyOnLoad(this);
        _darknessPanel = GameObject.Find("Darkness Panel").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (GameManager.Instance.GameState)
        {
            case GameState.LEVEL_ENDED:
                {
                    var color = _darknessPanel.color;
                    if (color.a >= 1) return;
                    color.a += LightsOffSpeed * Time.deltaTime;
                    _darknessPanel.color = color;
                }
                break;
            case GameState.LEVEL_START:
                {
                    var color = _darknessPanel.color;
                    if(color.a <= 0) return;
                    color.a -= LightsOffSpeed * Time.deltaTime;
                    _darknessPanel.color = color;
                }
                break;
        }
    }
}
