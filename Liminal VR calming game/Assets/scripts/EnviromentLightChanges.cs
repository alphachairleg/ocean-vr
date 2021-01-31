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
    private float colourtimer;

    //public GameObject hugeBubble;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        startTime = Time.time;

        GameObject hugeBubble = GameObject.Find("Bubble");
        ColorChanges playerScript = hugeBubble.GetComponent<ColorChanges>();
        //ColorChanges.hp;

        colourtimer = 0;

    }

    // Update is called once per frame
    void Update()
    {
       
       if (changeColors == true)
        {
            float t = (Mathf.Sin(Time.time - startTime * colorSpeed));
            myLight.color = Color.Lerp(startColor, endColor, t);
            //changeColors = false;
            Debug.Log("Lerp light");
            colourtimer += Time.deltaTime;
        }
       
        if (colourtimer >= 4)
        {
            changeColors = false;
        }

        if(changeColors == false)
        {
            colourtimer = 0;
        }
    }



}
