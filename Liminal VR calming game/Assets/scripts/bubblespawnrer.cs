using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblespawnrer : MonoBehaviour
{
    public GameObject bubble;
    public float spawnTimer ;
    public float spawnDelay;
    public float deathtimer = 6;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTimer, spawnDelay);
      
    }

    // Update is called once per frame
    void Update()
    {
        //change this to on vr buitton press
    }
    public void SpawnObject()
    {
        Instantiate(bubble, transform.position, transform.rotation);
       
        //  var delay = 2.0;
    }
}
