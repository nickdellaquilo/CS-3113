using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathplane : MonoBehaviour
{
    [SerializeField] private Transform respawn_point;
    public Transform playerTrans;

    private void OnTriggerEnter(Collider other) 
    {
        playerTrans.transform.position = respawn_point.transform.position;
    }

}
