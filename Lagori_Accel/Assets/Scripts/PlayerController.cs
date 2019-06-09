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
    private bool freeToCarry = true;
    UImanager UIreference;
    //SinkFunction reference; //to pass freeToCarry between scripts

    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        UIreference = GameObject.Find("Canvas").GetComponent<UImanager>();


       // reference = GameObject.Find("Sink").GetComponent<SinkFunction>();
      

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

    private void OnTriggerEnter2D(Collider2D other) // OnTriggerEnter para los kinematicos
    {
        Debug.Log("Player Collision detected ");
        string otherTag = other.gameObject.tag.ToString();

       // freeToCarry =  reference.getCanCarry();
       

        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            
        }

         if (otherTag.Contains("Stone") && freeToCarry )
         {
           other.gameObject.transform.SetParent(transform);
           Debug.Log("Touched " + otherTag);
            freeToCarry = false;
         }

       



    }

    public void  setCanCarry()
    {
        freeToCarry = true;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Collision detected ");
            UIreference.setGameOver();


        }
    }

}
