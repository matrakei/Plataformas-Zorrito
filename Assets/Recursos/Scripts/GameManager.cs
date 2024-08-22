using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private float cantidadPuntos = 0;
    string escenaActual;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Alterna entre las dos escenas
            if (escenaActual == "PlataformasZorrito")
            {
                ChangeScene("PlataformasZorrito 4to D 1");
            }
            else
            {
                ChangeScene("PlataformasZorrito");
            }
        }
    }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    private void Start()
    {
        escenaActual = SceneManager.GetActiveScene().name;
    }


    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
        Debug.Log("Coins: " + cantidadPuntos);
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
        escenaActual = scene;
    }
}
