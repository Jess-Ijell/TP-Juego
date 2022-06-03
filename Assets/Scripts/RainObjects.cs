using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject cubo;
    int contador = 0;
    GameObject clon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //int tiempo = Mathf.FloorToInt(Time.time);

        if (contador % 40 == 0)
        {
            clon = Instantiate(prefab);
            clon.transform.position = cubo.transform.position + new Vector3(10, 15, 0);
            Destroy(clon, 2);
        }

        contador++;
    }
}
