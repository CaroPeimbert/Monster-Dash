using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

   private float CheckPointX, CheckPointY; //
    //public SpriteRenderer animator;

    void Start()
    {
        if (PlayerPrefs.GetFloat("CheckPointX")!= 0)//preferencias del Player
        {
            transform.position =(new Vector2(PlayerPrefs.GetFloat("CheckPointX"), PlayerPrefs.GetFloat("CheckPointY"))); //nos regresa al punto de donde se ubica el CheckPoint
        }
    }
    public void CheckPointD(float x, float y)//cuando las coordenadas están guardas, ejecuta las posiciones
    {
        PlayerPrefs.SetFloat("CheckPointX", x);
        PlayerPrefs.SetFloat("CheckPointY", y);
    }
    public void PlayerDamage()//cuando colisionamos con el "enemigo", se reinicia la escena activa
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
