using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
        [SerializeField] private GameObject botonPausa;
        [SerializeField] private GameObject menuPausa;

        private bool juegoPausado = false;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(juegoPausado)
            {
                Reanudar();
            }
            else
            {
                PausaBoton();

            }
        }
    }

    public void PausaBoton()
    {
        juegoPausado = true;
        Time.timeScale = 0f; //Linea para que el juego se detenga cuando el boton sea presionado
        botonPausa.SetActive(false); // desactivar boton
        menuPausa.SetActive(true); //Activar boton
    }
    
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f; //Linea para que el juego continue
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        Debug.Log("Cerrando");
        Application.Quit();
    }
}
