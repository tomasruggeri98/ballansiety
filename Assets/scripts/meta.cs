using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meta : MonoBehaviour
{
    public GameObject panelNivelSuperado;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(NivelGanado()); // Llama a NivelGanado() con paréntesis ()
            panelNivelSuperado.SetActive(true);
        }
    }

    private static IEnumerator NivelGanado()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

