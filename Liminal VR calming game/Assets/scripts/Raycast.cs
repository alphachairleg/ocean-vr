using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public class ControllerInput : MonoBehaviour
    {
        public Transform pointerTransform; void Update()

        {
            if (OVRInput.Get(OVRInput.Button.SecondaryHandTrigger, OVRInput.Controller.Touch))
            {
                RaycastDirection();
            }
                if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
                {
                    RaycastDirection();
                } 
        }

        private void RaycastDirection()
        {
            RaycastHit selection;
            if (Physics.Raycast(pointerTransform.position, pointerTransform.forward, out selection))
            {
                if (selection.collider.gameObject.CompareTag("Bubble"))
                {
                    //spawn particle effect
                    Destroy(selection.collider.gameObject);
                }
            }
        }
    }

}
