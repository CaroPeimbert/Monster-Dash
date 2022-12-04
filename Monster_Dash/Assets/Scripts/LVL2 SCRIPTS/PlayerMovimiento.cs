using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum velocidades{Slow= 0, Normal= 1, Fast = 2, Faster= 3, Fastest= 4};
public class PlayerMovimiento : MonoBehaviour
{
    public velocidades VelocidadActual;
    float[] SpeedValues = {8.6f, 10.4f, 12.96f, 15.6f, 19.27f};

    void Update() 
    {
        transform.position += Vector3.right * SpeedValues[(int)VelocidadActual];
    }
}
