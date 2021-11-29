using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicaKnight : MonoBehaviour
{
    public float velMovimiento = 5.0f;
    public float velRotacion = 200.0f;
    public Animator anim; 
    public Rigidbody rb;
    public float x,y; 
    public bool estoyAtacando; 
    public float damage = 10.0f;
    public float impulsoGolpe = 10f; 
    public bool space;
  




    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        GameObject enemigo = GameObject.Find("Enemigo");
        //Enemigos_Salud enemyScript = enemigo.GetComponent<Enemigos_Salud>();
        
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
                rb.AddForce(new Vector3 (0,5f,0), ForceMode.Impulse); 
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

    private void OnTriggerEnter(Collider golpe)
    {
        
        if(golpe.gameObject.CompareTag("Enemigo") && estoyAtacando == true)
        {
            //enemyScript.health -= 5.0f;
        }
        if (golpe.tag == "objeto_N3")
        {
            golpe.gameObject.SetActive(false);
        }
        if (golpe.tag == "Lava_N3")
        {
            SceneManager.LoadScene("N3");
        }
    }
}
