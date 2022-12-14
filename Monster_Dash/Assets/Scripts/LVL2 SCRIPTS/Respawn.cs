using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform respawnPoint;

    void OnTriggerEnter2D(Collider2D other) 
   {
        player.transform.position = respawnPoint.transform.position;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }
}
