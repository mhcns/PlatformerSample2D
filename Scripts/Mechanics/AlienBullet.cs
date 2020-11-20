using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBullet : MonoBehaviour
{
    // Script do comportamento da bala do Alien.
    public float speed;
    public float ttl;            // Time to live, ou em outras palavras, range do tiro.
    private bool killed = false;
    private int timer = 0;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        killed = true;
    }
    void Update()
    {
        ttl -= Time.deltaTime;
        if (killed || ttl < 0)          //Entra na condição para destruir objeto caso atinja o player ou atinja a range limite.
        {
            timer += 1;
            if (timer > 1)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
