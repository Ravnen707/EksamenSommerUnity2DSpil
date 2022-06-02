using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float HP;
    public float MaxHP = 5;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
    }
    public void Takedmg(float damage)
    {
        HP -= damage;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
