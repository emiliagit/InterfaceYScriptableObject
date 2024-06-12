using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    
    public float distanciaRayCast;
    public float distanciaOverlap;
    //private bool hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        {
            InteractuarConObjeto();
        }
        if (Input.GetKey(KeyCode.E))
        {
           Atacar();
        }

        Movement();
    }

    private void InteractuarConObjeto()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distanciaRayCast))
        {    

        }

        Debug.DrawRay(transform.position, Vector3.up * distanciaRayCast, Color.red);

        if(hit.collider.GetComponent<IPresentacion>() != null )
        {
            Debug.Log("Interaccion" + hit.collider.name);

            hit.collider.GetComponent<IPresentacion>().Accion();
        }
        else
        {
            Debug.Log("no estoy interactuando con objetos");
        }

    }

    void Atacar()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, distanciaOverlap);

        foreach(var hitCollider in hitColliders )
        {
            if(hitCollider.GetComponent<ITakeDamage>() != null)
            {
                Debug.Log("le pegue" + hitCollider.name);
                hitCollider.GetComponent<ITakeDamage>().RecibirDaño(10);
            }
        }
    }

    private void Movement()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        Vector2 moveDirection = new(xInput, 0f);

        transform.Translate(moveSpeed * Time.deltaTime * moveDirection);
    }
}
