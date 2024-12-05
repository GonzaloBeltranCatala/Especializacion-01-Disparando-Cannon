using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject bala;

    GameObject posicionBala;

    GameObject cannon;

    GameObject prefab;

    float distancia;


    void Start()
    {
        posicionBala = GameObject.Find("PosicionBala");


        cannon = GameObject.Find("Cannon");

    }

    void Update()
    {
        if (prefab != null)
        {
            //cambia de color el ca�on cuando la bala se aleja de el
            distancia = Vector3.Distance(prefab.transform.position, posicionBala.transform.position);

            if (distancia >= 15f)
            {
                cannon.GetComponent<Renderer>().material.color = Color.grey;
            }

           
        }


    }


    private void OnMouseDown()
    {
        //instanciar bala
        prefab = Instantiate(bala, posicionBala.transform.position, Quaternion.identity);


        // movimiento bala
        Rigidbody rb = prefab.GetComponent<Rigidbody>();
        
        rb.AddForce(new Vector3(0, 10, 25), ForceMode.Impulse);


        //cambiar color del ca�on
        cannon.GetComponent<Renderer>().material.color = Color.yellow;

        //incrementar bala
        GameManager.AumentarBala();



    }


}
