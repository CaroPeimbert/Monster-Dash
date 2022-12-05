using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PortalesCheckpoints : MonoBehaviour
{
    public Gamemodes Gamemode;
    public velocidades Speed;
    public Gravity gravity;
    public int State;

    void OnCollisionEnter2D(Collision2D collision) 
    {
        try
        {
            PlayerMovimiento movement = collision.gameObject.GetComponent<PlayerMovimiento>();
            movement.CambioDePortales(Gamemode, Speed, gravity, State);
        }
        catch {}
    }

}
