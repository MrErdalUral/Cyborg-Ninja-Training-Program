using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public GameObject Owner;
    public int Damage = 1;
    [SerializeField]
    protected Transform Target;

    public abstract void SetTarget(Transform target);

    protected  virtual void OnTriggerEnter2D(Collider2D other)
    {
        if(Owner == null || other.gameObject == Owner) return;
        if (other.gameObject.tag == "Box" || other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            return;
        }
        var health = other.gameObject.GetComponent<Health>();
        if(health==null) return;
        health.Damage(1);
        var body = other.gameObject.GetComponent<Rigidbody2D>();
        if (body != null)
        {
            body.AddForce((Vector2)(other.transform.position - transform.position) * 50000);
        }
        Destroy(gameObject);
    }
}
