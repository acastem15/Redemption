using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_combate : MonoBehaviour
{
    public int health;
    public int dano;

    public Animator anime; 
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
            anime.Play("GermSpike_golpe");
            Destroy(gameObject);
        }
    }
}
