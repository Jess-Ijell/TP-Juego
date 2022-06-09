using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjects : MonoBehaviour
{
    public GameObject prefabEsfera;
    public GameObject prefabCilindro;
    public GameObject cubo;
    int contador = 1;
    GameObject clon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int tiempo = Mathf.FloorToInt(Time.time);

        if (contador % 70 == 0)
        {
            clon = Instantiate(prefabEsfera);
            clon.transform.position = cubo.transform.position + new Vector3(15, 15, 0);
            Destroy(clon, 2);
        }

        if (contador % 185 == 0)
        {
            clon = Instantiate(prefabCilindro);
            if (cubo.transform.position.z > 0)
            {
                clon.transform.position = cubo.transform.position + new Vector3(15, 15, -7);
            }

            if (cubo.transform.position.z < 0)
            {
                clon.transform.position = cubo.transform.position + new Vector3(15, 15, 7);
            }

            Destroy(clon, 2);
        }

        if (contador % 160 == 0)
        {
            clon = Instantiate(prefabCilindro);
            if (cubo.transform.position.z > 0)
            {
                clon.transform.position = cubo.transform.position + new Vector3(14, 15, -12);
            }

            if (cubo.transform.position.z < 0)
            {
                clon.transform.position = cubo.transform.position + new Vector3(14, 15, 12);
            }

            Destroy(clon, 2);
        }



        contador++;
    }
}
