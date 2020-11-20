using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    // Script que o player carrega com si para atualizar a posição do checkpoint
    public int cCheck = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var flag = collision.gameObject.GetComponent<SpawnFlag>();  // Incrementa toda vez que o player passa por um novo ponto de checkpoint.
        if(flag != null)
        {
            cCheck++;
        }
    }
}