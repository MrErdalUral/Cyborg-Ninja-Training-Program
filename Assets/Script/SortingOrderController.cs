using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingOrderController : MonoBehaviour
{

    private SpriteRenderer _renderer;

    // Use this for initialization
    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.sortingOrder = (int)(transform.position.y * -1000);
    }
}
