using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float speed;
    public Joystick horizontalJoystick;
    public Joystick verticalJoystick;
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        horizontalMove = horizontalJoystick.Horizontal * speed;
        verticalMove = verticalJoystick.Vertical * speed;
        Vector2 movement = new Vector2(horizontalMove, verticalMove);
        rb2d.velocity = movement;

    }
}
