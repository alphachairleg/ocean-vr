using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float Deathtimer = 8f;
    // var remains: GameObject;
    // Start is called before the first frame update
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
                Kill();
                killsmall();
            }

        }
        //   if (Input.GetKey(KeyDown.space))     change this get key down to whatever the occulus equivelent is
        //        {
        //          Instantiate(remains, transform.position, transform.rotation);    to create mini bubbles 
        //            Destroy(gameObject);
        //    }
    }
    private void OnCollisionEnter(Collision col)
    {

    }
    private void Kill()
    {
        Destroy(this.gameObject);
    }
    private void killsmall()
    {

        Destroy(gameObject);
    }
}