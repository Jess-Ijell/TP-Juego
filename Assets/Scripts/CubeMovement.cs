using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour
{
    public float movementSpeed;
    public Text Puntos;
    int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movementSpeed, 0, 0);

        if (transform.position.z >= 21.5)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(movementSpeed * 2, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0, 0, -movementSpeed * 2);
            }
        }

        else if (transform.position.z <= -21.5)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(movementSpeed * 2, 0, 0);
            }


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(0, 0, movementSpeed);
            }
        }

        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(movementSpeed * 2, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(0, 0, -movementSpeed * 2);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(0, 0, movementSpeed);
            }
        }


            //void OnCollisionEnter(Collision col)
            //{
            //    if (col.gameObject.name == "Cylinder(Clone)")
            //    {
            //        puntos++;
            //        Puntos.text = "Puntos: " + puntos;

            //    }

            //    if (col.gameObject.name == "Sphere(Clone)")
            //    {
            //        //perdió
            //    }
            //}

            //void OnCollisionExit()
            //{
            //    transform.position = posicion;
            //}

        }
}
