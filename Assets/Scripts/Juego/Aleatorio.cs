using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour
{
    public GameObject esfera;

    GameObject posicionBala;

    GameObject prefab;

    GameObject cruceta;

    List<Color> listaColores;

    int random;

 


    void Start()
    {
        posicionBala = GameObject.Find("PosicionBala");

        cruceta = GameObject.Find("Cruceta");

        listaColores = new List<Color>() { Color.red, Color.blue, Color.green, Color.yellow, Color.black };

    }


    private void OnMouseDown()
    {
        //instanciar
        prefab = Instantiate(esfera, posicionBala.transform.position, Quaternion.identity);

        //escala random
        prefab.transform.localScale = new Vector3(Random.Range(1f, 2f), Random.Range(1f, 2f), Random.Range(1f, 2f));


        //fuerza random
        Rigidbody rb = prefab.GetComponent<Rigidbody>();

        rb.AddForce(cruceta.transform.position, ForceMode.Impulse);

        //colores
        random = Random.Range(0, listaColores.Count);
        
        prefab.GetComponent<Renderer>().material.color = listaColores[random];

        //incrementar bala
        GameManager.AumentarBala();



    }
}
