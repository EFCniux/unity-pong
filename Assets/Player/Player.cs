using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Move(float inputY)
    {
        rigidBody.MovePosition(rigidBody.position + new Vector2(
            0,
            inputY * moveSpeed * Time.deltaTime
        ));
    }
}
