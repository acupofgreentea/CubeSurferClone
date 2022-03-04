using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private Transform player;

    private void Awake() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.transform.parent = player;
            other.gameObject.transform.localPosition = Vector3.zero;
        }
    }
}
