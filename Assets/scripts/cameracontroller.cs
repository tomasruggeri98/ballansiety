using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    private Vector2 angle = new Vector2 (90 * Mathf.Deg2Rad, 0); //la camara comienza mirando desde atras al jugador
    public Transform follow;
    public float distance;
    public Vector2 sensibilidad;


    
    void Start()
    {
       
        
    }

    private void Update()
    {
        float hor = Input.GetAxis("Mouse X");

        if (hor != 0) 
        {
            angle.x += hor * Mathf.Deg2Rad * sensibilidad.x;

        }

        float ver = Input.GetAxis("Mouse Y");
        if (ver != 0)
        {
            angle.y += ver * Mathf.Deg2Rad * sensibilidad.y;
            angle.y = Mathf.Clamp(angle.y, -80 * Mathf.Deg2Rad, 80 * Mathf.Deg2Rad);
        }

    }

    void LateUpdate()
    {
        Vector3 orbit = new Vector3(
            Mathf.Cos(angle.x) * Mathf.Cos(angle.y),
            -Mathf.Sin(angle.y),
            -Mathf.Sin(angle.x) * Mathf.Cos(angle.y)
            );
        transform.position = follow.position + orbit * distance;
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position);
        
    }
}
