using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int Hp = 3;

    public void Damage(int i)
    {
        Hp--;
        if (Hp <= 0)
        {
            if (gameObject.tag == "Player")
            {
                if(GetComponent<PlayerController>().State == EnemyState.ALIVE)
                    GetComponent<Animator>().SetTrigger("Death");
                GetComponent<PlayerController>().State = EnemyState.DEAD;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
