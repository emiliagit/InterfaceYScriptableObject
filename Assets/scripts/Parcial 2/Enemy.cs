using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    private int life = 10;
   

    public void TakeDamage(int amount)
    {
        life -= amount;

        Debug.Log("Enemy Llife: " + life);

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
