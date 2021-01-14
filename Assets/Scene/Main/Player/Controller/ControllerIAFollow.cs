using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Player))]
public class ControllerIAFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    private Player player;
    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void FixedUpdate()
    {
        var distanceY = target.transform.position.y - transform.position.y;
        player.Move(Mathf.Clamp(distanceY, -1.0f, 1.0f));
    }
}
