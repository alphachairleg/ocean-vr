using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentLightChanges : MonoBehaviour
{
    private Light myLight;
    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    public float startTime;

    //public GameObject hugeBubble;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;

        GameObject hugeBubble = GameObject.Find("Bubble");
        ColorChanges playerScript = hugeBubble.GetComponent<ColorChanges>();
        //ColorChanges.hp;
    }

    // Update is called once per frame
    void Update()
    {
       
       if (changeColors == true)
        {
            float t = Time.time - startTime * colorSpeed;
            myLight.color = Color.Lerp(startColor, endColor, t);
            Debug.Log("Lerp light");
        }
    }



}
