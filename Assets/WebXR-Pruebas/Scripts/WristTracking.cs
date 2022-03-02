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

    public GameObject prefabBoton2D;

    private GameObject botonMunyeca2D;

    void Start()
    {
        var handJointService = CoreServices.GetInputSystemDataProvider<IMixedRealityHandJointService>();
        if (handJointService != null)
        {
           Transform jointTransform = handJointService.RequestJointTransform(TrackedHandJoint.Wrist, Handedness.Right);
            botonMunyeca = Instantiate(prefabBoton,jointTransform);
            botonMunyeca2D = Instantiate(prefabBoton2D,jointTransform);  
        }
   
    }


}
