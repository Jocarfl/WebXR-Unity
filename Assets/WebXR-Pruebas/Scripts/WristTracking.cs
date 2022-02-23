using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;



public class WristTracking : MonoBehaviour
{
    public GameObject sphereMarker;

    GameObject sampleObject;


    void Start()
    {
        sampleObject = Instantiate(sphereMarker,this.transform);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose))
        {

            sampleObject.GetComponent<Renderer>().enabled = true;

            
            sampleObject.transform.position = pose.Position + new Vector3(0.0f, 0.04f, 0.0f);
            
            //Añadir 90 grados l eje X e Y para ajustar la rotación en la mano
            var rotation = Quaternion.Euler(90,90,0);
            sampleObject.transform.rotation = pose.Rotation * rotation;
            
            

        }else
        {
            sampleObject.GetComponent<Renderer>().enabled = false;

        }

    }
}
