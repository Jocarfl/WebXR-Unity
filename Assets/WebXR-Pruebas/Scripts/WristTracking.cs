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
        //sampleObject.transform.Rotate(90,90,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose))
        {

            sampleObject.GetComponent<Renderer>().enabled = true;
            sampleObject.transform.position = pose.Position;

            var rotation = Quaternion.Euler(90,90,0);
           
            sampleObject.transform.rotation = pose.Rotation * rotation;
            
            

        }else
        {
            sampleObject.GetComponent<Renderer>().enabled = false;

        }

    }
}
