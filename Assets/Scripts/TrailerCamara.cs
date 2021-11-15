using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerCamara : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;
    public GameObject camari;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        float musx = Input.GetAxis("Mouse X");

        camari.transform.Rotate(0f, musx, 0f);
        rb.AddForce(direction*velocidad);

        if (Input.GetKey("space")==true)
        {
            Vector3 arriba = new Vector3(0f, 1, 0f).normalized;
            rb.AddForce(arriba*velocidad);
        }
        
        if (Input.GetKey("left shift")==true)
        {
            Vector3 arriba = new Vector3(0f, -1, 0f).normalized;
            rb.AddForce(arriba*velocidad);
        }
    }
}
