using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0f;
    [SerializeField] float yValueRotate = 0f;
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float rotateSpeed = 5f;
    [SerializeField] GameObject cameras; 
    

    void Start()
    {
    
    }

  
    void Update()
    {
        Move();
    }
    
    
    void Move()
    {
        xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        yValueRotate = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        if (xValue < -Mathf.Epsilon) yValueRotate = yValueRotate * (-1);
        transform.Translate(0, 0, xValue);
        transform.Rotate(0, yValueRotate, 0);
        cameras.transform.rotation = gameObject.transform.rotation;
    }

}
