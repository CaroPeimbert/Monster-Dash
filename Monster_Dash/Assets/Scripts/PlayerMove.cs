using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float jumpSpeed = 4; //saltar
    Rigidbody2D rb2d; //movimiento
    public bool mejorSalto = true; //booleana para mejorar el salto
    public float saltoAlto= 0.5f;
    public float saltoBajo= 1f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb2d =GetComponent<Rigidbody2D>(); //referencia movimiento
    }
    private void Update() //Clase update, todo el tiempo que el juego se esté ejecutando se estara rpitiendo
    {
        if (Input.GetKey("space") ) //si pulsamos espacio
       
}
