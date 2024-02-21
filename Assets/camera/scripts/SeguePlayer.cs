using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguePlayer : MonoBehaviour
{
    public Transform Player;
    private Vector3 offSet;

    void Start()
    {
        offSet = transform.position - Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offSet;
    }
}
