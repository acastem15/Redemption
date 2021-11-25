using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runaestructura : MonoBehaviour
{
    public  float cantidadPilares = 0f;

    public GameObject[] pilares;
    public float cronometro; 
    public bool esfera=false; 
    public EsferaCup script;
    public GameObject runa; 
    public GameObject cup; 
    public bool parar=false; 
    public CantidadRunas scriptRunas; 
    public AudioClip sonidoRuna; 
    private AudioSource SonidoJugador; 


    // Start is called before the first frame update
    void Start()
    {
        SonidoJugador= GetComponent<AudioSource>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (script.esfera  == 1 && parar == false)
        {
            cantidadPilares += 1; 
            parar = true; 
        }
        if (cantidadPilares == 7)
        {
            //Sonido de activacion
            SonidoJugador.PlayOneShot(sonidoRuna,1.0f);

            //Se activa la runa
            cantidadPilares =0; 
            runa.SetActive(true);
            cup.SetActive(false); 
            scriptRunas.runasActivadas+=1; 

        }

        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("GoodPilar"))
        {
            cantidadPilares += 1; 
            other.GetComponent<BoxCollider>().enabled = false;
            

        }
        if (other.gameObject.CompareTag("BadPilar"))
        {
            cantidadPilares += 1; 
            other.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.SetActive (false);
            
            if (other.gameObject.name == "pillar3")
            {
                pilares[0].SetActive (true); 
                
            }
            if (other.gameObject.name == "pillar4")
            {
                pilares[1].SetActive (true); 
                
            }
            if (other.gameObject.name == "pillar5")
            {
                pilares[2].SetActive (true); 
                
            }
        }
        
        
            
        }
}
