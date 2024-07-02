using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WeaponObject", menuName = "Weapon")]
public class ScriptableWeapon : ScriptableObject
{

    [SerializeField] private string nombre;
    [SerializeField] private int daño;
    [SerializeField] private string rango;

    public string Nombre { get { return nombre; } }
    public int Vida { get { return daño; } }
    public string Saludo { get { return rango; } }

    public void PrintData()
    {
        Debug.Log("Nombre: " + nombre);
        Debug.Log("Vida maxima: " + daño);
        Debug.Log("Rango: " + rango);
    }
}
