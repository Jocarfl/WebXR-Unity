using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;



public class WristTracking : MonoBehaviour
{
    public GameObject prefabBoton;
    private GameObject botonMunyeca;

    void Start()
    {
        // Instanciar el botón en la escena
        botonMunyeca = Instantiate(prefabBoton,this.transform);
               
    }

    
    void Update()
    {
        if(HandJointUtils.TryGetJointPose(TrackedHandJoint.Wrist, Handedness.Right, out MixedRealityPose pose))
        {
            //Renderizar el botón al detectar la muñeca de la mano derecha
            botonMunyeca.GetComponent<Renderer>().enabled = true;

            //Ajustar la posición del botón   
            botonMunyeca.transform.position = pose.Position + new Vector3(0.0f, 0.04f, 0.0f);
            
            //Añadir 90 grados al eje X e Y para ajustar la rotación en la mano
            var rotation = Quaternion.Euler(90,90,0);
            botonMunyeca.transform.rotation = pose.Rotation * rotation;
        }
    }


}
