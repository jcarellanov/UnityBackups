using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        //float width = renderer.bounds.size.x;
        //float height = renderer.bounds.size.y;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Color myColor = gameObject.GetComponent<SpriteRenderer>().color;
        Color otherColor = other.gameObject.GetComponent<SpriteRenderer>().color;
        Debug.Log( "myColor is " + myColor.ToString() );
        Debug.Log("Ball is " + otherColor.ToString());

        if (myColor == otherColor)
        {
            other.gameObject.SetActive(false);
            Debug.Log("Color Match");


        }

    }
}
