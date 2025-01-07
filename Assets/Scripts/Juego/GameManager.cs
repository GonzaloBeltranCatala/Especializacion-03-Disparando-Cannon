using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    static public GameObject textoBalas;

    static public GameObject textoDianas;

    static public GameObject textoPotencia;


    static int numBala = 0;

    static int numDiana = 0;

    static int numPotencia = 0;

    public int contadorDiana = 0;


    int numAleatorioX;

    int numAleatorioY;

    int aleatorioAnteriorX;

    int aleatorioAnteriorY;

    Vector3 posicionAleatoria;


    public GameObject diana;


    public GameObject panel;

    public GameObject elementos;

    public GameObject cruceta;

    public GameObject ganar;

    public GameObject perder;


    public GameObject balaRes;

    public GameObject dianaRes;

    public GameObject porcentajeRes;

    float resultado;


    void Start()
    {
        textoBalas = GameObject.Find("NumBala");

        textoDianas = GameObject.Find("NumDianas");

        textoPotencia = GameObject.Find("NumPotencia");


        //mover diana a una posicion aleatoria

        // x -35 a 35
        // y -6 a 13
        //z 81

        numAleatorioX = Random.Range(-35, 36);

        numAleatorioY = Random.Range(-6, 14);

        // guardamos el valor para luego hacer la comprobacion para no repetirlo
        aleatorioAnteriorX = numAleatorioX;

        aleatorioAnteriorY = numAleatorioY;


        
        posicionAleatoria = new Vector3(numAleatorioX, numAleatorioY, 81);

        Instantiate(diana, posicionAleatoria, diana.transform.rotation);


    

    }

    public void GenerarDiana()
    {

        //no repetir la misma posicion en X
        numAleatorioX = Random.Range(-35, 36);

        while (numAleatorioX == aleatorioAnteriorX)
        {
            numAleatorioX = Random.Range(-35, 36);
        }

        //no repetir la misma posicion en Y

        numAleatorioY = Random.Range(-6, 14);

        while (numAleatorioY == aleatorioAnteriorY)
        {
            numAleatorioY = Random.Range(-6, 14);
        }

        //crea diana

        posicionAleatoria = new Vector3(numAleatorioX, numAleatorioY, 81);

        Instantiate(diana, posicionAleatoria, diana.transform.rotation);


        //guardar el valor actual
        aleatorioAnteriorX = numAleatorioX;

        aleatorioAnteriorY = numAleatorioY;

    }

    

    static public void ResetBala()
    {
        numBala = 0;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();
    }

    static public void AumentarBala()
    {
        numBala++;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();


    }

    static public void DisminuirBala()
    {

        numBala--;

        textoBalas.GetComponent<TextMeshProUGUI>().text = numBala.ToString();

    }

    static public void AumentarDiana()
    {
        numDiana++;

        textoDianas.GetComponent<TextMeshProUGUI>().text = numDiana.ToString();

    }

    static public void AumentarPotencia()
    {
  
        numPotencia++;

        textoPotencia.GetComponent<TextMeshProUGUI>().text = numPotencia.ToString();


    }

    static public void ResetPotencia()
    {

        numPotencia = 0;

        textoPotencia.GetComponent<TextMeshProUGUI>().text = numPotencia.ToString();


    }

    static public int Potencia()
    {

        return int.Parse(textoPotencia.GetComponent<TextMeshProUGUI>().text);

    }

    public void Ganar()
    {

        panel.SetActive(true);

        ganar.SetActive(true);

        perder.SetActive(false);

        balaRes.GetComponent<TextMeshProUGUI>().text = textoBalas.GetComponent<TextMeshProUGUI>().text.ToString();

        dianaRes.GetComponent<TextMeshProUGUI>().text = textoDianas.GetComponent<TextMeshProUGUI>().text.ToString();

        //dianas entre balas por cien

        resultado = (float.Parse(textoDianas.GetComponent<TextMeshProUGUI>().text) / float.Parse(textoBalas.GetComponent<TextMeshProUGUI>().text)) * 100;

        porcentajeRes.GetComponent<TextMeshProUGUI>().text = resultado.ToString();
        
        

        elementos.SetActive(false);

        cruceta.SetActive(false);

    

    }


    public void Perder()
    {

        panel.SetActive(true);

        ganar.SetActive(false);

        perder.SetActive(true);

        balaRes.GetComponent<TextMeshProUGUI>().text = textoBalas.GetComponent<TextMeshProUGUI>().text.ToString();


        dianaRes.GetComponent<TextMeshProUGUI>().text = textoDianas.GetComponent<TextMeshProUGUI>().text.ToString();


        //dianas entre balas por cien

        resultado = (float.Parse(textoDianas.GetComponent<TextMeshProUGUI>().text) / float.Parse(textoBalas.GetComponent<TextMeshProUGUI>().text)) * 100;

        porcentajeRes.GetComponent<TextMeshProUGUI>().text = resultado.ToString();





        elementos.SetActive(false);

        cruceta.SetActive(false);

    
    }



}
