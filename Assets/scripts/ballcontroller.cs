using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballcontroller : MonoBehaviour
{
    [SerializeField] private float force;     // movimiento
    [SerializeField] private Rigidbody rb;   
    public float jumpForce;                   //fuerza salto

    void Start()
    {
        rb = GetComponent<Rigidbody>();     
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");    // entrada horizontal
        float verticalInput = Input.GetAxis("Vertical");        // entrada vertical

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        rb.AddForce(direction * force, ForceMode.Force);   // una fuerza para mover la bola

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);   //fuerza hacia arriba al presionar la barra espaciadora para salto
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("derrota"))    // si colisiona con "derrota"
        {
            RestartScene();    //reiniciar  escena
        }
    }

    public void RestartScene() // obtener escena actual ycargar la escena actual 
    {
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        
        SceneManager.LoadScene(currentSceneIndex);
    }
}


