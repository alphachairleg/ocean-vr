using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanges : MonoBehaviour
{
    public float hp = 30;
    MeshRenderer sphereMeshRenderer;
    [SerializeField] [Range(0f, 1f)] float lerpTime;

    [SerializeField] Color[] myColours;

    public GameObject HugePopLight;
    public GameObject HugePopLight2;
    public ParticleSystem HugePop;

    float t = 0f;
    int colorIndex = 0;
    int len;


    private void Start()
    {
        Color color = Color.red;
        float f = 0.4f;
      

        sphereMeshRenderer = GetComponent<MeshRenderer>();
        len = myColours.Length;

    }

    //================UPDATE=================
    void Update()
    {
        if (hp <= 50)
        {

            //changes the colour of the material slowly over time
            sphereMeshRenderer.material.color = Color.Lerp(sphereMeshRenderer.material.color, myColours[colorIndex], lerpTime * Time.deltaTime);
            t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);

            if (t > .9f)
            {
                //t= 0f is the starting point before it begins changing colours
                t = 0f;

                //colour index is what lets you choose how many colours you want to use
                colorIndex++;
                colorIndex = (colorIndex >= len) ? 0 : colorIndex;
            }
        }

        /* if (hp <= 1)
         {
             HugePopLight.GetComponent<EnviromentLightChanges>().changeColors = true;
             HugePopLight2.GetComponent<EnviromentLightChanges>().changeColors = true;
         }*/

        if (hp <= 0)
        {
            Instantiate(HugePop, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("pooooooooooooooop");

            HugePopLight.GetComponent<EnviromentLightChanges>().changeColors = true;
            HugePopLight2.GetComponent<EnviromentLightChanges>().changeColors = true;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Bubble")
        {
            hp -= 1;
            Debug.Log("hp -1");
        }

        /*if (hp <= 0)
        {
            Instantiate(HugePop, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("pooooooooooooooop");

            HugePopLight.GetComponent<EnviromentLightChanges>().changeColors = true;
            HugePopLight2.GetComponent<EnviromentLightChanges>().changeColors = true;
        }*/
    }



}
