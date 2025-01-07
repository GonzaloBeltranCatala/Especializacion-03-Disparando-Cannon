using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canyon : MonoBehaviour
{

    GameObject cruceta;


    // Start is called before the first frame update
    void Start()
    {
        cruceta = GameObject.Find("Cruceta");

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cruceta.transform);
    }
}
