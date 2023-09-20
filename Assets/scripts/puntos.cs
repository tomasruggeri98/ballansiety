using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntos : MonoBehaviour
{
    public float points;
    public Text textopuntos;





    void Start()
    {
        
    }

    
    void Update()
    {
        textopuntos.text = points.ToString();


    }
}
