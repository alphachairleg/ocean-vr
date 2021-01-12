using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlock : MonoBehaviour
{

    public GameObject fishPrefab;
    //public List<GameObject> Fishes;
    public static int tankSize = 15;
    public GameObject goalPrefab;

    //Fishes spawn number
    static int numFish = 30;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;

    void Start()
    {
        for(int i = 0; i < numFish; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize),
                Random.Range(-tankSize, tankSize),
                Random.Range(-tankSize, tankSize));
            allFish[i] = (GameObject)Instantiate(fishPrefab,pos, Quaternion.identity);
        }
    }


    void Update()
    {
        if(Random.Range(0, 10000) < 50)
        goalPos = new Vector3(Random.Range(-tankSize, tankSize),
                               Random.Range(-tankSize, tankSize),
                               Random.Range(-tankSize, tankSize));

        goalPrefab.transform.position = goalPos;
    }
}
