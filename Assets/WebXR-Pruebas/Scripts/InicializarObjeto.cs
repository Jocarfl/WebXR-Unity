using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializarObjeto : MonoBehaviour
{
    public GameObject menuPrueba;

    private GameObject menu;
    private int cont=0;
    public void OnButtonPressed()
    {
        cont++;
        if(cont<=1)
        {
            menu = Instantiate(menuPrueba,menuPrueba.transform);
        }
        else
        {
            Destroy(menu);
            cont = 0;
        }
    
        
    }
    public void OnButtonDeselect()
    {
        
    }


}
