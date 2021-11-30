using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_combate : MonoBehaviour
{
    public int health;
    public int dano = 2;
    public Barra_Vida_Logica BVL;

    public Animator anime; 
    //public CantidadMuertos muertos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "arma")
        {
            if (anime != null)
            {
                anime.Play("GermSpike_golpe");
            }

            BVL.vida_actual -= dano;
            BVL.vida_actual -= health;
            health -= dano;
        }

        if (health <= 0)
        {
            anime.Play("GermSpike_golpe");
            Destroy(gameObject);
            //muertos.cantidad += 1;
        }
    }
}
