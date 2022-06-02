using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjects : MonoBehaviour
{
    public GameObject prefab;

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
            Instantiate(prefab);
            contador += 1;
        }
        
        
    }
}
