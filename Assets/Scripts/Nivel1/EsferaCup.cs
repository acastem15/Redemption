using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaCup : MonoBehaviour
{
    public float esfera =0f;
    public float cronometro;
    public bool colocado;  
    public GameObject esferaObject; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (colocado && esfera ==0)
        {
            cronometro += 1*Time.deltaTime; 
            if (cronometro >=5)
                {
                    if (colocado)
                    {
                        esfera += 1; 
                        this.gameObject.GetComponent<BoxCollider>().enabled = false;
                        esferaObject.gameObject.transform.SetParent(this.gameObject.transform);
                        cronometro = 0; 
                        
                    }

                }

//Revisa el trigger con esfera (este script es para el cup), espera 5 segundos para verificar que el objeto sigue ahi
// Si sigue ahí (coloacdo sigue en true) entonces lo añade
        }
    }
private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("object"))
        {
            colocado = true; 
            esferaObject = other.gameObject;
            

        }
}
private void OnTriggerExit(Collider other) {
    if (other.gameObject.CompareTag("object"))
        {
            colocado = false; 
            

        }
//Activar y desactivar colocado
}


}
