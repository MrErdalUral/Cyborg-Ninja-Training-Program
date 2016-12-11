using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject AttackObjectPrefab;
    public float AttackCooldownTime = 1f;
    public float AttackForce = 10f;
    private Vector3 _lookingVector;
    private float _cooldown;
    // Update is called once per frame
    void Awake()
    {
        _cooldown = 0;
    }
    void Update()
    {
        ControlRotation();
        ControlAttack();
    }

    private void ControlAttack()
    {
        _cooldown -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && _cooldown <= 0)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookingVector = mousePosition - transform.position;
            var angle = Mathf.Atan2(lookingVector.y, lookingVector.x) * Mathf.Rad2Deg;
            var instance = Instantiate(AttackObjectPrefab, transform.position +(Vector3) lookingVector.normalized,
                Quaternion.AngleAxis(angle, Vector3.forward));
            var projectileScript = instance.GetComponent<LinearProjectile>();
            projectileScript.Owner = transform.parent.gameObject;
            projectileScript.SetAttackVector(lookingVector);
            var playerBody = GetComponentInParent<Rigidbody2D>();
            playerBody.AddForce(lookingVector.normalized * AttackForce);
            _cooldown += AttackCooldownTime;
        }
    }


    protected void ControlRotation()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        _lookingVector = mousePosition - transform.position;
        if (!SwitchDirection)
            transform.localScale = new Vector3(-1, 1, 1);
        else
        {
            _lookingVector = new Vector3(_lookingVector.x,-_lookingVector.y,0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        var angle = Mathf.Atan2(_lookingVector.y, _lookingVector.x) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public bool SwitchDirection { get; set; }
}
