using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteR;
    private int firstSprite = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        firstSprite = Random.Range(0, 4);
        spriteR.sprite = sprites[firstSprite];
        switch (firstSprite)
        {
            case 0:
                gameObject.tag = "Stone1";
                break;

            case 1:
                gameObject.tag = "Stone2";
                break;

            case 2:
                gameObject.tag = "Stone3";
                break;

            case 3:
                gameObject.tag = "Stone4";
                break;

            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
