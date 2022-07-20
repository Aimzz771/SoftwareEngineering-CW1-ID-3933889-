using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInputH;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {
        moveInputH = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInputH * speed, rb.velocity.y);
        if (moveInputH != 0)
        {
            playerVariables.isWalking = true;

        }
        else
        {
            playerVariables.isWalking = false;
        }
    }
}
