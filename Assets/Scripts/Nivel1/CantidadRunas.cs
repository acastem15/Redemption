using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantidadRunas : MonoBehaviour
{

    public int runasActivadas; 
    public AudioClip sonidoTerminarRunas; 
    private AudioSource SonidoJugador; 
    public GameObject portal; 
    public GameObject UIPortalActivo; 
    public float cronometro;
    public bool SeActivo=false; 
    // Start is called before the first frame update
    void Start()
    {
        SonidoJugador= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (runasActivadas == 5)
        {

            portal.SetActive(true); 
            SonidoJugador.PlayOneShot(sonidoTerminarRunas,1.0f);
            UIPortalActivo.SetActive(true);
            runasActivadas=0; 
            SeActivo=true; 

        }

    }
}
