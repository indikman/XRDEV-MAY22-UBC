using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintHead : MonoBehaviour
{
    [SerializeField] private Material defaultMaterial;
    public bool hasPaintAttached = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("paintcolor"))
        {
            GetComponent<MeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
            hasPaintAttached = true;
        } 
        else if(other.CompareTag("water"))
        {
            GetComponent<MeshRenderer>().material = defaultMaterial;
            hasPaintAttached = false;
        }
    }
}
