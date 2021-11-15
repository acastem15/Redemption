using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaKnight : MonoBehaviour
{
    public float velMovimiento = 5.0f;
    public float velRotacion = 200.0f;
    private Animator anim; 
    public Rigidbody rb;
    public float x,y; 
    public bool estoyAtacando; 
    public float impulsoGolpe = 10f; 
    public bool space;




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame

    void FixedUpdate() 
    {
        if (estoyAtacando == false) {
        
        
        transform.Rotate(0, x*Time.deltaTime*velRotacion, 0);
        transform.Translate(0,0,y*Time.deltaTime*velMovimiento);

        }
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal"); 
        y = Input.GetAxis("Vertical");
        


        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (estoyAtacando == false) 
        {
            if (Input.GetKeyDown("space"))
            {
                anim.SetBool("Space", true);
                space = true; 
            }
        }

        if (Input.GetMouseButtonDown(0) && space == false)
        {
            anim.SetTrigger("Golpe1"); 
            estoyAtacando = true; 

        }
        if (Input.GetMouseButtonDown(1) && space == false)
        {
            anim.SetTrigger("Golpe2"); 
            estoyAtacando = true; 
            

        }
        if (Input.GetMouseButtonDown(2) && space == false)
        {
            anim.SetTrigger("Golpe3"); 
            estoyAtacando = true; 
            

        }

    }
    void NoSpace()
    {
        anim.SetBool("Space", false);
        space = false;
    }

    void DejarGolpear()
    {
        estoyAtacando = false;
    }
    void NuevaPosicion()
    {
        rb.velocity = transform.forward * impulsoGolpe;

    }

}