using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    public float thrust = .00000000040f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(thrust == 1) { 
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
            }
    }
  
}
