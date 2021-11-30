using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_combate : MonoBehaviour
{
    public int health;
    public int dano = 2;

    public Animator anime; 
    public CantidadMuertos muertos;
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

            health -= dano;
        }

        if (health <= 0)
        {
            muertos.cantidad += 1;
            anime.Play("GermSpike_golpe");
            Destroy(gameObject);
        }
    }
}
