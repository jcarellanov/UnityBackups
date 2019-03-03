using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    private Rigidbody2D enemyBody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        enemyBody =  GetComponent<Rigidbody2D>();
        Vector2 movement = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
        enemyBody.AddForce(movement*speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
