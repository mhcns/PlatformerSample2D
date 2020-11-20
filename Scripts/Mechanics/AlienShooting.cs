using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mechanics;

public class AlienShooting : MonoBehaviour
{
    public float fireRate;
    public GameObject alienbullet;
    public Transform bulletSpawn;

    internal RigidbodyType2D rb;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    void Fire()
    {
        Instantiate(alienbullet, bulletSpawn.position, bulletSpawn.rotation);
    }

    private void Update()
    {
        rb = GetComponent<Rigidbody2D>().bodyType;
        if (rb == RigidbodyType2D.Kinematic)    //Objeto é do tipo Kinematic enquanto está vivo, e vira Dynamic quando morre.
        {                                       // Also, condição para que inimigo pare de atirar após morrer.
            timer += Time.deltaTime;
            if (timer >= fireRate)
            {
                Fire();
                timer = 0;
            }
        }
    }

}

