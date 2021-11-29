using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CantidadMalos : MonoBehaviour
{
    public int cantidad = 0; 
    public LogicaKnight script; 
    public GameObject SeAcabo; 
    public float cronometro; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (cantidad >= 3)
        {
            script.anim.SetBool("muerto", true);

            cronometro += 1*Time.deltaTime;
            if (cronometro >=2)
                {
            
                    SeAcabo.SetActive(true); 
                    cronometro =0f; 
                    cantidad = 0; 
                }

        
        }
        
    }
}
