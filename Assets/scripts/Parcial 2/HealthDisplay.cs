using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    public TextMeshProUGUI healthtext;
    private int MaxHealth;
    private int MinHealth;

    // Start is called before the first frame update
    
    private void AgregarVida()
    {
        MaxHealth++;
        healthtext.text = "healt:" + MaxHealth;
    }

    private void OnEnable()
    {
        PlayerHealth.healthIncreased += AgregarVida;
        PlayerHealth.healthDecreased += RestarVida;
    }

    private void OnDisable()
    {
        PlayerHealth.healthIncreased -= AgregarVida;
        PlayerHealth.healthDecreased -= AgregarVida;

    }


    private void RestarVida()
    {
        MinHealth--;
        healthtext.text = "healt:" + MinHealth;
    }

}
