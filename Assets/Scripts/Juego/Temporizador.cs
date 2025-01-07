using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Temporizador : MonoBehaviour
{

    GameObject cronometroCanvas;

    TextMeshProUGUI cronometroTexto;

    public float totalSegundos;

    GameObject manager;


  
    void Start()
    {

        manager = GameObject.FindGameObjectWithTag("Manager");
        
        cronometroCanvas = GameObject.Find("Tiempo");

        cronometroTexto = cronometroCanvas.GetComponent<TextMeshProUGUI>();

        // modo dificil
        if (MenuPrincipal.dificultad)
        {
            totalSegundos = 15;
        }

        // modo facil
        else
        {
            totalSegundos = 20;
        }

        

        cronometroTexto.text = totalSegundos.ToString();

    }

    void Update()
    {       
        totalSegundos = totalSegundos - Time.deltaTime;


        if (totalSegundos < 0)
        {
            totalSegundos = 0;

            //gameover

            manager.GetComponent<GameManager>().Perder();


        }


        Actualizar();
        
    }


    void Actualizar()
    {

        float minutos = Mathf.FloorToInt(totalSegundos / 60);

        float segundos = Mathf.FloorToInt(totalSegundos % 60);

        cronometroTexto.text = string.Format("{0:00}:{1:00}", minutos, segundos);


    }


    public void AumentarTiempo()
    {
        // modo dificil
        if (MenuPrincipal.dificultad)
        {
            totalSegundos = totalSegundos + 1;
        }

        // modo facil
        else
        {

            totalSegundos = totalSegundos + 3;

        }

       


    }
}
