using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //Bubble fire audio
    public AudioClip clip;
    private AudioSource audioSource;

    private Rigidbody rbody;
    public GameObject bullet;
    public Transform gun;
    public float shootRate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;

        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Click button
        if(OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            //Audio play
            audioSource.Play();
            
            //Bubble fire rate
            if(Time.time > shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                    bullet, gun.position, gun.rotation);
                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                shootRateTimeStamp = Time.time + shootRate;
            }

        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == true)
        {
            //Audio play
            audioSource.Play();
        }
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == false)
        {
            //Audio play
            audioSource.Pause ();
        }
    }

   
}
