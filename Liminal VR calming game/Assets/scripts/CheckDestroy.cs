using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDestroy : MonoBehaviour
{
    public GameObject HugeBubble01;
    public GameObject HugeBubble02;
    public ParticleSystem FireFlyYellow;

    // Start is called before the first frame update

    void Update()
    {
        if (HugeBubble01 == null)
        {
            HugeBubble02.SetActive(true);
            Debug.Log("HB02 active");
        }

        /*if (HugeBubble02 == null)
        {
            
            if (!FireFlyYellow.isPlaying)
            {
                FireFlyYellow.Play();
                Debug.Log("firefly active");
            }
        }*/

       
    }

    private void FixedUpdate()
    {
        if (HugeBubble02 == null)
        {

            if (!FireFlyYellow.isPlaying)
            {
                FireFlyYellow.Play();
                Debug.Log("firefly active");
            }
        }
    }


}
