using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializarObjeto : MonoBehaviour
{
    public GameObject menuPrueba;

    private GameObject menu;

    public void OnButtonPressed()
    {
        menu = Instantiate(menuPrueba,menuPrueba.transform);
        
    }
    public void OnButtonDeselect()
    {
        Destroy(menu);
        
    }


}
