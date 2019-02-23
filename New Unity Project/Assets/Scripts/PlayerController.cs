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
    // Start is called before the first frame update

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.acceleration.x;
        //float moveHorizontal = Input.GetAxis("Horizontal"); //float moveHorizontal=Input.acceleration.x;
        float moveVertical = Input.acceleration.y;
       //float moveVertical = Input.GetAxis("Vertical"); //Input.acceleration.y
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement*speed);
        /*
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                
                position = new Vector3(-pos.x, pos.y, 0.0f);

                // Position the cube.
                transform.position = position;
            }
        }
        */
    }

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
