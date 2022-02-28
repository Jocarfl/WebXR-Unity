using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;



public class WristTracking : MonoBehaviour
{
    public GameObject prefabBoton;
    private GameObject botonMunyeca;

    void Start()
    {
        var handJointService = CoreServices.GetInputSystemDataProvider<IMixedRealityHandJointService>();
        if (handJointService != null)
        {
           Transform jointTransform = handJointService.RequestJointTransform(TrackedHandJoint.Wrist, Handedness.Right);
            botonMunyeca = Instantiate(prefabBoton,jointTransform);  
        }
   
    }


}
