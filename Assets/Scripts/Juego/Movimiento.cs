using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    GameObject cruceta;

    Vector3 movimiento;

    // Start is called before the first frame update
    void Start()
    {
        cruceta = GameObject.Find("Cruceta");
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = cruceta.transform.position;

        float posicionX = movimiento.x;

        float posicionY = movimiento.y;

        float posicionZ = movimiento.z;

        if (Input.GetKey("w"))
        {
            posicionY++;

        }

        if (Input.GetKey("a"))
        {
            posicionX--;
        }

        if (Input.GetKey("s"))
        {
            posicionY--;
        }

        if (Input.GetKey("d"))
        {
            posicionX++;
        }

        Vector3 nuevaPosicion = new Vector3(Mathf.Clamp(posicionX, -25f, 25f), Mathf.Clamp(posicionY, -1f, 20f), posicionZ);


        cruceta.transform.position = nuevaPosicion;

        

    }

        
}
