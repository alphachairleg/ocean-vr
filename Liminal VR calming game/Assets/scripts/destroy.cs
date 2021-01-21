using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float Deathtimer = 8f;
    // var remains: GameObject;


    public ParticleSystem bubblePop;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Deathtimer >= 0)
        {
            Deathtimer -= Time.deltaTime;
            if (Deathtimer <= 0)
            {
                Destroy();
                //Kill();
                //killsmall();
            }

        }
        //   if (Input.GetKey(KeyDown.space))     change this get key down to whatever the occulus equivelent is
        //        {
        //          Instantiate(remains, transform.position, transform.rotation);    to create mini bubbles 
        //            Destroy(gameObject);
        //    }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand" /*&& other.tag == "Ground" && other.tag == "Fish"*/)
        {

            Destroy();
        }
        else if (other.gameObject.tag == "Ground")
        {
            Destroy();
        }
        else if (other.gameObject.tag == "Fish")
        {
            Destroy();
        }
    }

    /*private void Kill()
    {
        Destroy();
    }*/

    public void Destroy()
    {
        Instantiate(bubblePop, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    /*private void killsmall()
    {

        Destroy(gameObject);
    }*/
}