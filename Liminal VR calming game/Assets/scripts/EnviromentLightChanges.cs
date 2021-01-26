using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentLightChanges : MonoBehaviour
{
    public Light myLight;
    public bool changeColors = false;
    public float colorSpeed = 1.0f;
    public Color startColor;
    public Color endColor;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // if( bubble popped changeColors==true)
        if (changeColors)
        {
            float t = Time.time - startTime * colorSpeed;
            myLight.color = Color.Lerp(startColor, endColor, t);
        }
    }

}
