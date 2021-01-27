using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleChildPop : MonoBehaviour
{

    public GameObject pooooopBubble;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fish")
        {
            
            pooooopBubble.gameObject.GetComponent<destroy>().Destroy();
        }
       
        
    }
}
