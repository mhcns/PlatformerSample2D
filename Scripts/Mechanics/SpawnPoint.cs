using UnityEngine;
using Platformer.Mechanics;
public class SpawnPoint : MonoBehaviour
{
    public int ID;
    public GameObject player;

    private int check;
    //private GameObject yolo;
    private void Awake()
    {
        //yolo = FindObjectOfType<PlayerController>().gameObject;
        ID = FindObjectOfType<SpawnSystem>().cCheck;        // Inicia��o da vari�vel de verifica��o de checkpoint
    }
    private void Update()
    {
        check = FindObjectOfType<SpawnSystem>().cCheck;
        if (ID != check)                                           // Caso a ID do checkpoint atual for diferente da que o player atingiu,
        {
            transform.position = FindObjectOfType<PlayerController>().transform.position;           // a posi��o do checkpoint � atualizada
            ID = check;                                            // junto com sua ID
        }
    }
}