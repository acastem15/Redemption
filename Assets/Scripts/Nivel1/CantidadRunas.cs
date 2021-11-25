using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantidadRunas : MonoBehaviour
{

    public int runasActivadas; 
    public AudioClip sonidoTerminarRunas; 
    private AudioSource SonidoJugador; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runasActivadas == 5)
        {
            SonidoJugador.PlayOneShot(sonidoTerminarRunas,1.0f);
            Debug.Log("SeAcabo");

        }
    }
}
