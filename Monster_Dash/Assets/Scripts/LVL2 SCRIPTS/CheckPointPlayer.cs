using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) { 
    if (collision.CompareTag("Player"))
    {
        //cuando el Player colisiona con el checkpoint, guarda la posición en X y Y
        collision.GetComponent<Respawn>().CheckPointD(transform.position.x,transform.position.y);
        GetComponent<Animator>().enabled=true;
    }
   }
}

