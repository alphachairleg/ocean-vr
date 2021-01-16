using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{
    public float thrust = .00000000040f;
    public Rigidbody rb;
    private bool bubbleleft;
    private float Timer;


    //  public float Shakespeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        bubbleleft = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer++;
        if (thrust == 1)
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }

        if (bubbleleft == true)
        {
            transform.position += transform.forward * Time.deltaTime;

            if (Timer >= 80)
            {
                bubbleleft = false;
                TimerReset();
            }
        }

        if (bubbleleft == false)
        {
            transform.position -= transform.forward * Time.deltaTime;
            if (Timer >= 80)
            {
                bubbleleft = true;
                TimerReset();
            }
        }

        /* Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * Shakespeed);
         newPos.y = transform.position.y;
         newPos.z = transform.position.z;
         transform.position = newPos;
        accidental tornado code
        */
    }
    public void TimerReset()
    {
        Timer = 0;
    }

}

