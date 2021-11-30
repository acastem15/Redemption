using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntajeContador : MonoBehaviour
{
    public int puntaje = 100; 
    public string mensaje; 
    public Text texto; 
    public GameObject portal;
    public GameObject seacabo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("gemasN3"))
        {
            puntaje +=5; 
            mensaje= puntaje.ToString(); 
            texto.text = mensaje + " $"; 


        }
        if (other.gameObject.CompareTag("objeto_N3"))
        {
            puntaje -=10; 
            mensaje= puntaje.ToString(); 
            texto.text = mensaje + " $"; 

        }
        if (other.gameObject.CompareTag("meta_N3"))
        {
            if (puntaje <= 65)
            {
                portal.gameObject.SetActive(true);
            }
            else
            {
                seacabo.gameObject.SetActive(true);
            }
        }
    }
}
