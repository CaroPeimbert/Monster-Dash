using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    
    private void OnTriggerEnter2D(Collider2D collision) //solo si esta en el suelo podemos brincar
    {
        isGrounded = true;    
    }

    private void OnTriggerExit2D(Collider2D collision) //Si la box colaider sale del suelo entonces es falso
    {
        isGrounded = false;    
    }
}
