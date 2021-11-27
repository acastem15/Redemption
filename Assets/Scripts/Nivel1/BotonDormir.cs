using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonDormir : MonoBehaviour
{
    public bool dormirB=false; 
    public GameObject negro; 
    public GameObject capa; 
    public GameObject panel; 
    public Material Noche; 
    public float cronometro; 
    public GameObject dificil; 
    private AudioSource SonidoJugador;
    public AudioClip sonidoDormir;
    public CantidadMalos malosescogidos;  
    // Start is called before the first frame update
    void Start()
    {
        SonidoJugador= GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Hacer de noche
        if (dormirB)
        {
            
            RenderSettings.skybox=Noche; 
            
            negro.SetActive(true);
            
            
            SonidoJugador.PlayOneShot(sonidoDormir,1.0f);
            cronometro += 1*Time.deltaTime; 
            if (cronometro >=3)
                {
                    float x = 0.1f;  
                    capa.SetActive(true);
                    Image image = capa.GetComponent<Image>();
                    var tempColor = image.color;
                    tempColor.a = tempColor.a +x;
                    image.color = tempColor;

                    dificil.SetActive(true); 
                    negro.SetActive(false); 
                    panel.SetActive(false); 
                    malosescogidos.cantidad +=1; 
                    dormirB=false;
                    cronometro =0f; 
                }
            
            
            
        }
        
    }
    public void dormir()
    {
       dormirB = true; 
       
        
    }
}
