using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class ScaleToCameraY : MonoBehaviour
{
    private void Awake()
    {
        var positionXLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        var positionXRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        transform.localScale = new Vector3(
            (positionXLeft - positionXRight),
            transform.localScale.y,
            transform.localScale.z
        );
    }
}
