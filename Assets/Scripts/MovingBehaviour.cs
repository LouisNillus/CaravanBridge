using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBehaviour : MonoBehaviour
{

    public RacerTyper racerType;
    private Rigidbody2D rb;
  

    // Start
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = racerType.sprite;

        if (!this.GetComponent<Rigidbody2D>())
            Debug.LogError("Missing Rigidbody2D on this gameObject");

        rb = this.GetComponent<Rigidbody2D>();

        rb.mass = racerType.mass;
        rb.gravityScale = racerType.gravity;
    }

    // Update
    void Update()
    {
        
    }

    //FixedUpdate
    void FixedUpdate()
    {
        //Movement();
        MovementBis();
    }

    public void Movement()
    {
        switch (racerType.direction)
        {
            case RacerTyper.Direction.Left:
                this.transform.Translate(Vector3.left * Time.deltaTime * racerType.forceApplied);
                break;
            case RacerTyper.Direction.Right:
                this.transform.Translate(Vector3.right * Time.deltaTime * racerType.forceApplied);
                break;
        }
    }

    public void MovementBis()
    {
        switch (racerType.direction)
        {
            case RacerTyper.Direction.Left:
                rb.velocity = (Vector2.left * racerType.forceApplied * Time.deltaTime);
                break;
            case RacerTyper.Direction.Right:
                rb.velocity = (Vector2.right * racerType.forceApplied * Time.deltaTime);
                break;
        }
    }
}
