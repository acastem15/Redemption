using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilar : MonoBehaviour
{

    public GameObject goodPilar=null; 
    public UnaRuna script; 
    public GameObject yo; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            if(yo.CompareTag("BadPilar"))
            {
            yo.SetActive(false); 
            goodPilar.SetActive(true); 
            yo.GetComponent<BoxCollider>().enabled = false;
            script.cantidad+= 1; 
            }
            if(yo.CompareTag("GoodPilar"))
            {
               script.cantidad += 1; 
               yo.GetComponent<BoxCollider>().enabled = false;

            }
        }
    }
}
