using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador_meta : MonoBehaviour
{
    public GameObject seacabo;
    public GameObject portal;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) 
    {
        if (other.transform.tag == "Player")
        {
            
        }
    }
}
