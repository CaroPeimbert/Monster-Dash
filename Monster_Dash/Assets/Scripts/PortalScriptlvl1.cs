using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PortalScriptlvl1 : MonoBehaviour
{
    public Gamemodes Gamemode;
    public Speeds Speed;
    public Gravity gravity;
    public int State;

    void OnCollisionEnter2D(Collision2D collision) 
    {
        try
        {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ChangeThroughPortal(Gamemode, Speed, gravity, State);
            SceneManager.LoadScene("Level 2");
        }
        catch {}
    }
    

}
