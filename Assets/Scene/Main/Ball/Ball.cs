using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetMovement();
    }
    
    public void ResetMovement()
    {
        var isRight = Random.Range(0, 2) == 0;
        rigidBody.velocity = (isRight ? Vector2.right : Vector2.left) * moveSpeed;
    }
}
