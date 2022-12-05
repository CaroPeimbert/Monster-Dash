using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
     private float CheckPointX,CheckPointY; //Se guarda la informacion del player al colisionar con la bandera

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetFloat("CheckPointX")!=0) //Informacion del Punto de control en x
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("CheckPointX"),PlayerPrefs.GetFloat("CheckPointY")));
        }
    }
    public void CheckPointLogrado(float x, float y) //Punto de control guardado
    {
        PlayerPrefs.SetFloat("CheckPointX" , x); //Punto de control ejecutado
        PlayerPrefs.SetFloat("CheckPointY" , y);
    }
    public void DañoPersonaje()
    {
               SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Se reinicia la escena
    }
    
}

