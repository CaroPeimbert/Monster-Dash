using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageReloadScene : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision) {//cuando colisionan las dos box collider, llama al código de respawn y reaparece al personaje y activa la anim de daño

       if(collision.transform.CompareTag("Player"))
       {
           collision.transform.GetComponent<Respawn>().PlayerDamage();//llama al código de respawn
       }
   }
}
