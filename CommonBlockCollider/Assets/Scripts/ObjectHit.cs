using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(gameObject.tag != "Hit")
            {
                Debug.Log("Wall Collison");
                GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
                gameObject.tag = "Hit";
            }

        }
    }
}
