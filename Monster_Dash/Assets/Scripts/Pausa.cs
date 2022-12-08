using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
        [SerializeField] private GameObject botonPausa;
        [SerializeField] private GameObject menuPausa;

    public void PausaBoton()
    {
        Time.timeScale = 0f; //Linea para que el juego se detenga cuando el boton sea presionado
        botonPausa.SetActive(false); // desactivar boton
        menuPausa.SetActive(true); //Activar boton
    }
    
    public void Reanudar()
    {
        Time.timeScale = 1f; //Linea para que el juego continue
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
}
