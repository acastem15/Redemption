using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    Rigidbody myRB;
    // Start is called before the first frame update
    private void OnEnable() 
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision other) 
    {
        if (other.transform.tag == "Player")
        {
            myRB.isKinematic = true;
        }
    }
}
