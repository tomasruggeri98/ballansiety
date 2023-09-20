using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointtopick : MonoBehaviour
{
    public GameObject ObjPuntos;
    public float puntosQueDa;

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Player")
        {
            ObjPuntos.GetComponent<puntos>().points += puntosQueDa;
            Destroy(gameObject);
        }
    }




}
