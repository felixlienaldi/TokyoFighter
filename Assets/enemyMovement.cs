using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    [HideInInspector] public float Attack;
    [HideInInspector] public float Health;
    [HideInInspector] public float Speed;

    private Rigidbody2D rb;
    public Transform target;

    // Use this for initialization
    void Start () {
        Speed = 3f;
        target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        move(); 
    }
    
    public void move()
    {
        Vector3 direction = (transform.position - target.position);
        if (direction.x < 0)
        {
            rb.velocity = new Vector2(Speed, 0f);
        }
        else if (direction.x > 0)
        {
            rb.velocity = new Vector2(-Speed, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
}
