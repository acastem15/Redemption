using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarMensaje : MonoBehaviour
{
    public GameObject panelMostrar; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other) {
 
            panelMostrar.SetActive(true); 

    }
    private void OnTriggerExit(Collider other) {

            panelMostrar.SetActive(false); 
    }

}
