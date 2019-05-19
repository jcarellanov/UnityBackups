using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkFunction : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteR;
    public float secondsBetweenChange = 0.0f;
    private float elapsedTime = 0.0f;
    private int firstSprite = 0;


    private void Awake()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        firstSprite = Random.Range(0, 4);
        spriteR.sprite = sprites[firstSprite];
    }

    // Start is called before the first frame update
    void Start()
    {
    
       
    }



    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > secondsBetweenChange)
        {
            elapsedTime = 0;
            firstSprite = Random.Range(0, 4);
            spriteR.sprite = sprites[firstSprite];
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag.ToString());
        if(other.gameObject.tag.ToString()  == "Stone1")
        {
            other.gameObject.SetActive(false);
            Debug.Log("Stone Disappeared");
        }

    }

    
}
