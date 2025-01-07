using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public GameObject menuJuego;

    public GameObject menuCreditos;


    public GameObject facil;

    public GameObject dificil;

    public static bool dificultad = false;

    


   


    public void Jugar()
    {

        SceneManager.LoadScene("Juego");

    }

    public void Creditos()
    {
        
        menuCreditos.SetActive(true);

        menuJuego.SetActive(false);



    }


    public void Atras()
    {
        menuJuego.SetActive(true);


        menuCreditos.SetActive(false);

    }

    public void Facil()
    {
        facil.SetActive(true);

        dificil.SetActive(false);


        dificultad = false;

    }

    public void Dificil()
    {
        facil.SetActive(false);

        dificil.SetActive(true);


        dificultad = true;

    }

}
