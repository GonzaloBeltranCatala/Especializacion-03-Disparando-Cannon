using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminar : MonoBehaviour
{

    GameObject[] balas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {

        balas = GameObject.FindGameObjectsWithTag("Bala");

        for (int i = 0; i < balas.Length; i++)
        {

            Destroy(balas[i]);


        }

        //Cambiar numero de balas a 0
        GameManager.ResetBala();

    }

}
