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
    public Transform Sprite;
    

    void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() 
    {
        transform.position += Vector3.right * SpeedValues[(int)VelocidadActual] *Time.deltaTime;

        if (OnGround())
        {
            Vector3 Rotation = Sprite.rotation.eulerAngles;
            Rotation.z = Mathf.Round(Rotation.z/90)*90;
            Sprite.rotation = Quaternion.Euler(Rotation);


            if (Input.GetMouseButton(0))
            {
               rb2d.velocity = Vector2.zero;
               rb2d.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);
            }
        }
        else
        {
            Sprite.Rotate(Vector3.back *5);
        }
    }
    bool OnGround()
    {
        return Physics2D.OverlapCircle(GroundCheckTransform.position, GroundCheckRadius, GroundMask);
    }
}
