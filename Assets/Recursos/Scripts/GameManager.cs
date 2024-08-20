using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private float cantidadPuntos;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }


    public void Sumarpuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
            {

            SceneManager.LoadScene("PlataformasZorrito 4to D 1");
        }
    }




}
