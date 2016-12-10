using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int Hp = 3;

    public void Damage(int i)
    {
        Hp--;
        if(Hp <= 0)
            Destroy(gameObject);
    }
}
