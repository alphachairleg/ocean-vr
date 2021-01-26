using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreTagCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bubble")
        {
           Physics.IgnoreCollision(Bubble.collider, collider);
        }

        //Freeze rotation
        //rb.constraints = RigidbodyConstraints.FreezeRotationZ;
    }
}
