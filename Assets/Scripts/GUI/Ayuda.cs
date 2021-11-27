using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ayuda : MonoBehaviour
{
    public GameObject panelSalir; 
    public GameObject panelPoner; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ponerPanel()
    {
        panelSalir.SetActive(false); 
        panelPoner.SetActive(true); 

    }

}
