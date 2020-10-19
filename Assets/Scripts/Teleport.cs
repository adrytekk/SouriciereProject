using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject _teleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleport"))
        {
            transform.position = _teleport.transform.position;
        }
    }
}
