using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicaFinal : MonoBehaviour
{
    public bool final; 
    public GameObject videoPlayer; 
  
    public GameObject video; 
    public float cronometro; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (final)
        {
            videoPlayer.SetActive(true); 
            video.SetActive(true); 

            cronometro += 1*Time.deltaTime;
            if (cronometro >=10)
            { 
                Application.Quit(); 
                videoPlayer.SetActive(false); 
                video.SetActive(false); 
 
                

            }
        }
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
           final = true; 
        }
    }
}
