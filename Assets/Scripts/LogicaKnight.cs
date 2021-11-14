using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaKnight : MonoBehaviour
{
    public float velMovimiento = 5.0f;
    public float velRotacion = 200.0f;
    private Animator anim; 
    public float x,y; 
    public double cronometro;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); 
        y = Input.GetAxis("Vertical");
        
        transform.Rotate(0, x*Time.deltaTime*velRotacion, 0);
        transform.Translate(0,0,y*Time.deltaTime*velMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("Space", true);
        }



        

    }
    void NoSpace()
    {
        anim.SetBool("Space", false);
    }
}
