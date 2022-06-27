using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubeMovement : MonoBehaviour
{
    public float movementSpeed;
    public Text Puntos;
    int puntos = 0;
    public GameObject Panel;
    public Text PuntosFinales;
    public Text GanastePerdiste;
    public AudioClip SonidoGano;
    AudioSource fuenteAudio;
    int repSonido = 1;
    public GameObject confetti;
    int cantConfetti = 30;
    public Text tiempo;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < 196 && Panel.activeInHierarchy == false)
        {
            tiempo.text = "Tiempo: "+Mathf.FloorToInt(Time.timeSinceLevelLoad).ToString();

            transform.position += new Vector3(movementSpeed, 0, 0);
                    
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(movementSpeed * 2, 0, 0);
            }

            if (transform.position.z >= 21.5)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.position += new Vector3(0, 0, -movementSpeed);
                }
            }

            else if (transform.position.z <= -21.5)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.position += new Vector3(0, 0, movementSpeed);
                }
            }

            else
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.position += new Vector3(0, 0, movementSpeed);
                }


                if (Input.GetKey(KeyCode.RightArrow))
                {
                    transform.position += new Vector3(0, 0, -movementSpeed);
                }
            }
        }
        

        if (transform.position.x >= 196)
        {
            Panel.SetActive(true);
            GanastePerdiste.text = "¡Ganaste!";
            PuntosFinales.text = "Sumaste un total de: "+puntos+" puntos.";
        }

        if (GanastePerdiste.text == "¡Ganaste!" && repSonido == 1)
        {
            fuenteAudio.PlayOneShot(SonidoGano);
            repSonido++;
            tiempo.text = "Tiempo: 0";
        }
    
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("juego");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "prefmanzana(Clone)")
        {
            Vector3 posColision = col.gameObject.transform.position;
            Destroy(col.gameObject, 0.2f);
            int i;
            GameObject clon;

            for (i = 1; i <= cantConfetti; i++)
            {
                clon = Instantiate(confetti);
                clon.transform.position  = posColision;
                Destroy(clon, 1);
            }

            puntos++;
            Puntos.text = "Puntos: " + puntos;

        }

        if (col.gameObject.name == "prefbomba(Clone)")
        {
            Panel.SetActive(true);
            GanastePerdiste.text = "¡Perdiste!";
            PuntosFinales.text = "Has perdido todos tus puntos.";
            tiempo.text = "Tiempo: 0";
        }
    }

    void OnCollisionExit()
    {
            
    }
}
