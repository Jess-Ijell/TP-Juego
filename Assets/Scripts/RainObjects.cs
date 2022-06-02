using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjects : MonoBehaviour
{
    public GameObject prefab;
    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int tiempo = Mathf.FloorToInt(Time.time);
        int contador = 0;

        while (tiempo > contador && contador <= 10)
        {
            GameObject clon = Instantiate(prefab);
            contador += 1;
            clon.transform.position += new Vector3(0, 0, 2);
        }
        
        
    }
}
