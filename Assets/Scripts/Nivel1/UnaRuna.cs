using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnaRuna : MonoBehaviour
{
    public  float cantidad= 0f;
    public AudioClip sonidoRuna; 
    private AudioSource SonidoJugador; 
    public GameObject runa; 
    public GameObject cup;
    public CantidadRunas scriptRunas;

    // Start is called before the first frame update
    void Start()
    {
        SonidoJugador= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cantidad >= 7)
        {
            //Sonido de activacion
            SonidoJugador.PlayOneShot(sonidoRuna,1.0f);
            scriptRunas.runasActivadas+=1; 

            //Se activa la runa
            
            runa.SetActive(true);
            cup.SetActive(false); 
            cantidad =0; 
            
            

            //scriptRunas.runasActivadas+=1; 

        }
        
    }
}
