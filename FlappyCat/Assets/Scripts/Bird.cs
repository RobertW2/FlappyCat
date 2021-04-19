using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    private const float JUMP_AMOUNT = 40f;
    private Rigidbody2D birdRigidbody2D;
    private void Awake()
    {
        birdRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
     {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
     }

    private void Jump()
    {
        birdRigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("yo");
    }
}
