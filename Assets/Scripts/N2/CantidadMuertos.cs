using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantidadMuertos : MonoBehaviour
{
    public int cantidad; 
    public GameObject portal; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cantidad>=7)
        {
            portal.SetActive(true); 
        }
        
    }
}
