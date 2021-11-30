using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_combate : MonoBehaviour
{
    public int health;
    public int dano;
    public Animator anime; 
    
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Enemigo")
        {
            health -= dano;
        }

        if (health <= 0)
        {
            anime.SetBool("muerto", true);
        }
    }
}
