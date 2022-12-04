using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum velocidades{Slow= 0, Normal= 1, Fast = 2, Faster= 3, Fastest= 4};
public class PlayerMovimiento : MonoBehaviour
{
    public velocidades VelocidadActual;
    float[] SpeedValues = {8.6f, 10.4f, 12.96f, 15.6f, 19.27f};

    public Transform GroundCheckTransform;
    public float GroundCheckRadius;
    public LayerMask GroundMask;
    Rigidbody2D rb2d;

    void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        transform.position += Vector3.right * SpeedValues[(int)VelocidadActual] *Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (OnGround())
            {
               rb2d.AddForce(Vector2.up * 26.6581);
            }
        }
    }
    bool OnGround()
    {
        return Physics2D.OverlapCircle(GroundCheckTransform.position, GroundCheckRadius, GroundMask);
    }
}
