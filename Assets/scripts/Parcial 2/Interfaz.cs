using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interfaces de actividad scriptable object
public interface IPresentacion
{
    public void Accion();
}

public interface ITakeDamage
{
    public void RecibirDa�o(int dmg);
}


//interfaz de parcial 2
public interface IDamageable
{
    public void TakeDamage(int amount);
}
