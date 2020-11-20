using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAim : MonoBehaviour
{
    // Script para fazer o Alien mirar no Player.
    private Transform player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    void Align()
    {
        Vector2 direction = player.position - transform.position;
        Quaternion rotation = Quaternion.FromToRotation(transform.up, direction);
        transform.rotation = rotation * transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Align();
    }
}