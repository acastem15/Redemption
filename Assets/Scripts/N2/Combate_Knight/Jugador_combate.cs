using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_combate : MonoBehaviour
{
    public int health;
    public int dano;
    public Animator anime; 
    public bool muerto;
    public GameObject panel;
    
    void Update()
    {
        if (muerto == true)
        {
            anime.SetBool("muerto", true);
            panel.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Enemigo")
        {
            health -= dano;
        }

        if (health <= 0)
        {
            
            muerto = true;
        }
    }
}
