using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;
    [SerializeField]
    private bool isRight;

    private Rigidbody2D rigidBody;
    private new SpriteRenderer renderer;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        renderer = GetComponentInChildren<SpriteRenderer>();

        // Calc initial position from camera bounds
        var positionX = Camera.main.ViewportToWorldPoint(new Vector3(
            isRight ? 1 : 0,
            0,
            0
        )).x;

        rigidBody.transform.position = new Vector3(
            isRight ? positionX - renderer.size.x : positionX + renderer.size.x,
            rigidBody.transform.position.y,
            rigidBody.transform.position.z
        );
    }

    public void Move(float inputY)
    {
        rigidBody.MovePosition(rigidBody.position + new Vector2(
            0,
            inputY * moveSpeed * Time.deltaTime
        ));
    }
}
