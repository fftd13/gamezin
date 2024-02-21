using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporte : MonoBehaviour
{
    public GameObject Saida;
    private GameObject Gobj;
    private BoxCollider2D col;
    public bool Horizontal;
    private bool PlayerDetectado;
    public float AddDistance;

    // Start is called before the first frame update
    void Start()
    {
        PlayerDetectado = false;
        col = GetComponent<BoxCollider2D>();

        // Determine a direção com base no tamanho do collider
        Horizontal = col.size.x < col.size.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerDetectado)
        {
            if (Horizontal)
            {
                Gobj.transform.position = new Vector3(Saida.transform.position.x + AddDistance, Gobj.transform.position.y);
            }
            else
            {
                Gobj.transform.position = new Vector3(Gobj.transform.position.x, Saida.transform.position.y + AddDistance);
            }
        }
        
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerDetectado = true;
            Gobj = col.gameObject;

            
        }
    }
}
