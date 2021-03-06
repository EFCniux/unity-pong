using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    [SerializeField]
    private bool isRight;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == target)
        {
            print(collision.ToString());
        }
    }
}
