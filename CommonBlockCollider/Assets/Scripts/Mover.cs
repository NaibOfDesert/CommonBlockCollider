using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float zValue = 0f;
    

    void Start()
    {
    
    }

  
    void Update()
    {
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical"); 
        transform.Translate(xValue, 0, zValue);
    }


}
