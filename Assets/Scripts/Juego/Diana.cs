using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Diana : MonoBehaviour
{

    GameObject bala;

    GameObject manager;

    GameObject crono;

    GameObject diana;


    float tiempo = 1;


    void Start()
    {
        bala = GameObject.FindGameObjectWithTag("Bala");

        diana = GameObject.FindGameObjectWithTag("Diana");

        manager = GameObject.FindGameObjectWithTag("Manager");

        crono = GameObject.FindGameObjectWithTag("Tiempo");

    }

    void Update()
    {

        tiempo = tiempo + Time.deltaTime;
 
        
        
        if ((int)tiempo % 5 == 0)
        {
            manager.GetComponent<GameManager>().GenerarDiana();

            Destroy(gameObject);
        }

        
    

    }

   

    private void OnCollisionEnter(Collision collision)
    {
        
        //aumenta el tiempo
        crono.GetComponent<Temporizador>().AumentarTiempo();

        //audio
        manager.GetComponent<AudioSource>().Play();


        GameManager.AumentarDiana();


        manager.GetComponent<GameManager>().contadorDiana = manager.GetComponent<GameManager>().contadorDiana + 1;

        
        Destroy(gameObject);


        if( manager.GetComponent<GameManager>().contadorDiana == 10)
        {

            manager.GetComponent<GameManager>().Ganar(); 


        }

        else
        {
            manager.GetComponent<GameManager>().GenerarDiana();

        }


        

        



    }



    

}
