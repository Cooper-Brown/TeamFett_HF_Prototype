using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingCollider : MonoBehaviour
{

    public GameObject guidanceSystem;

    private void OnTriggerEnter(Collider other)
    {
        guidanceSystem.SetActive(false);
    }
}