using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlag : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject player;

    private Collider2D playerCollider;
    internal CircleCollider2D trigger;
    private SpriteRenderer sprite;
    private AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = player.GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)     
    {
        if (player != null)
        {
            Destroy(GetComponent<CircleCollider2D>());                              // Uma vez que o player chega no checkpoint, o trigger é destruído,
            sprite.color = new Color(255, 255, 255, 255);                           // a bandeira muda de cor e um áudio é tocado avisando que o checkpoint foi alcançado.
            AudioSource.PlayClipAtPoint(_audio.clip, transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
