using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{

    protected Transform Target;

    public abstract void SetTarget(Transform target);
}
