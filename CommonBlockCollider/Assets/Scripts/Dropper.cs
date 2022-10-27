using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToDrop = 2f;
    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time > timeToDrop) && rigidbody.useGravity == false)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
        // Debug.Log(Time.time); 
    }
}
