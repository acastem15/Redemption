using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSlime_combate : MonoBehaviour
{
    public int health = 4;
    public int dano = 2;
    public Barra_Vida_Logica BVL;
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

            BVL.vida_actual -= dano;
            BVL.vida_actual = health;
        }

        if (health <= 0)
        {
            muertos.cantidad += 1;
            Destroy(gameObject);
        }
    }
}
