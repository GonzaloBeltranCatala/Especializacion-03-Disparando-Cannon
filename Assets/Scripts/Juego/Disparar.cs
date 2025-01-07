using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject bala;

    GameObject posicionBala;

    GameObject cannon;

    GameObject prefab;

    GameObject cruceta;

    float distancia;

    bool cargar = false;

    int potenciaFinal;



    void Start()
    {
        posicionBala = GameObject.Find("PosicionBala");

        cannon = GameObject.Find("Cannon");

        cruceta = GameObject.Find("Cruceta");

    }

    void Update()
    {
        if (prefab != null)
        {
            //cambia de color el cannon cuando la bala se aleja de el
            distancia = Vector3.Distance(prefab.transform.position, posicionBala.transform.position);

            if (distancia >= 15f)
            {
                cannon.GetComponent<Renderer>().material.color = Color.grey;
            }

           
        }

        if (cargar)
        {
            
            GameManager.AumentarPotencia();

            if (GameManager.Potencia() == 100)
            {
                cargar = false;
            }
        }


    }

    


    private void OnMouseDown()
    {
        GameManager.ResetPotencia();

        cargar = true;



    }

    private void OnMouseUp()
    {
        cargar = false;

        potenciaFinal = GameManager.Potencia() / 20;

        //instanciar bala
        prefab = Instantiate(bala, posicionBala.transform.position, Quaternion.identity);


        // movimiento bala
        Rigidbody rb = prefab.GetComponent<Rigidbody>();


        rb.AddForce(cruceta.transform.position * potenciaFinal, ForceMode.Impulse);


        //cambiar color del canon
        cannon.GetComponent<Renderer>().material.color = Color.yellow;

        //incrementar bala
        GameManager.AumentarBala();


        
    }





}
