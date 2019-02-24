using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    private Rigidbody2D rb2d;
    private int count;
    private Vector3 position;
    public Joystick joystick;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    // Start is called before the first frame update

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    private void Update()
    {
        horizontalMove = joystick.Horizontal * speed;
        verticalMove = joystick.Vertical * speed;
        Vector2 movement = new Vector2(horizontalMove, verticalMove);
        //rb2d.AddForce(movement);
        rb2d.velocity = movement;
        
     

    }
    /*
     * 
    
    private void Update()
    {
        if (Input.touchCount > 0) // move object to finger position
        {  
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;

        }
    }*/
    /*
    private void FixedUpdate() // move object with accelerometr
    {
        float moveHorizontal = Input.acceleration.x;
        //float moveHorizontal = Input.GetAxis("Horizontal"); //float moveHorizontal=Input.acceleration.x;
        float moveVertical = Input.acceleration.y;
       //float moveVertical = Input.GetAxis("Vertical"); //Input.acceleration.y
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement*speed);
       
        
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
            winText.text = "You Win";

    }
}
