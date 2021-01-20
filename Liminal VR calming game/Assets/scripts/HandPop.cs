using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    /*private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Hand")
        {
            Destroy(this.gameObject);
        }

    }*/

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            Debug.Log("pop");
            Destroy(gameObject);
        }
    }

}
