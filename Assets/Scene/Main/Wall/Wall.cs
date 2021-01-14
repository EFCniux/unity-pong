using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Wall : MonoBehaviour
{
    private void Awake()
    {
        // Calc necesary scale to fit main camera
        var positionXLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        var positionXRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        transform.localScale = new Vector3(
            (positionXLeft - positionXRight) * 1.25f,
            transform.localScale.y,
            transform.localScale.z
        );
    }
}
