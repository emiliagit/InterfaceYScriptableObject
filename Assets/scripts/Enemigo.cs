using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour, IPresentacion, ITakeDamage
{
    [SerializeField] private ScriptableEnemy enemyData;

    private int life;
   
  
    void Start()
    {
        life = enemyData.Vida;
    }

    
    public void Accion()
    {
        enemyData.PrintData();
    }

    public void RecibirDaño(int dmg)
    {
        life -= dmg;

        Debug.Log(enemyData.Nombre + "-Vida: " + life);
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
