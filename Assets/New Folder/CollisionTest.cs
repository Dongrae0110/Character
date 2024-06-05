using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
  

    void OnTriggerEnter(Collider other) 
    {
        Utils.Log("충돌함 " + other.gameObject.name);
    }

     void OnTriggerExit(Collider other) 
    {
        Utils.Log("충돌 벗어남 " + other.gameObject.name);
    }

    void OnCollisionEnter(Collision collision) 
    {
        Utils.Log("======>물리 충돌함 " + collision.gameObject.name);

    }

     void OnCollisionExit(Collision collision) 
    {
        Utils.Log("======>물리 충돌 벗어남 " + collision.gameObject.name);
    }
}
