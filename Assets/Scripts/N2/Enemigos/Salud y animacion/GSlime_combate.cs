using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSlime_combate : MonoBehaviour
{
    public int health;
    public int dano;
    public Animator anime; 
    public CantidadMuertos muertos; 
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "arma")
        {
            if (anime != null)
            {
                anime.Play("GermSlime_golpe");
            }
            health -= dano;
        }

        if (health <= 0)
        {
            muertos.cantidad += 1;
            Destroy(gameObject);
        }
    }
}
