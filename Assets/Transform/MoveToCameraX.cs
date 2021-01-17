using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class MoveToCameraX : MonoBehaviour
{
    [SerializeField]
    private bool isRight;
    [SerializeField]
    private float distanceX = 0;

    private void Awake()
    {
        var positionX = Camera.main.ViewportToWorldPoint(new Vector3(
            isRight ? 1 : 0,
            0,
            0
        )).x;

        transform.position = new Vector3(
            isRight ? positionX - distanceX : positionX + distanceX,
            transform.position.y,
            transform.position.z
        );
    }
}
