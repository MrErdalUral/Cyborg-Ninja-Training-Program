using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingEnemyController : StationaryEnemyController
{

    public Transform point1;
    public Transform point2;

    public float moveSpeed = 2f;
    private int targetPoint;
    private Vector3 pos1;
    private Vector3 pos2;
    void Awake()
    {
        pos1 = point1.position;
        pos2 = point2.position;
        targetPoint = 1;
    }
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (targetPoint == 1)
        {
            transform.position += (pos1 - transform.position).normalized * moveSpeed * Time.deltaTime;
            if ((transform.position - pos1).sqrMagnitude <= 1)
                targetPoint = 2;
        }
        else if (targetPoint == 2)
        {
            transform.position += (pos2 - transform.position).normalized * moveSpeed * Time.deltaTime;
            if ((transform.position - pos2).sqrMagnitude <= 2)
                targetPoint = 1;
        }
    }
}
