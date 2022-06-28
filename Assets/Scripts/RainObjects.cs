using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjects : MonoBehaviour
{
    public GameObject prefabEsfera;
    public GameObject prefabCilindro;
    public GameObject cubo;
    public GameObject panel;
    public int a;
    GameObject clon;
    int contador = 1;
    public AudioClip AudioEsfera;
    AudioSource fuenteAudio;


    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeInHierarchy == false && cubo.transform.position.x <= 160)
        {
            if (contador % 70 == 0)
            {
                clon = Instantiate(prefabEsfera);
                clon.transform.position = cubo.transform.position + new Vector3(22, 25, 0);
                Destroy(clon, 2.5f);

                if (!fuenteAudio.isPlaying)
                {
                    fuenteAudio.PlayOneShot(AudioEsfera);
                }
            }

            if (contador % 185 == 0)
            {
                clon = Instantiate(prefabCilindro);
                if (cubo.transform.position.z > 0)
                {
                    clon.transform.position = cubo.transform.position + new Vector3(20, 25, -7);
                }

                if (cubo.transform.position.z < 0)
                {
                    clon.transform.position = cubo.transform.position + new Vector3(20, 25, 7);
                }

                Destroy(clon, 2.5f);
            }

            if (contador % 160 == 0)
            {
                clon = Instantiate(prefabCilindro);
                if (cubo.transform.position.z > 0)
                {
                    clon.transform.position = cubo.transform.position + new Vector3(20, 25, -12);
                }

                if (cubo.transform.position.z < 0)
                {
                    clon.transform.position = cubo.transform.position + new Vector3(20, 25, 12);
                }

                Destroy(clon, 2.5f);
            }
                    
            contador++;
        }        
    }
}
