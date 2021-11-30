using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador_combate : MonoBehaviour
{
    public int maxhealth = 20;
    public float health;
    public int dano;
    public Animator anime; 
    public bool muerto;
    public GameObject panel;
    public Image BarraVida;
    
    
    void Start()
    {
        health = maxhealth;
    }
    void Update()
    {
        RevisarVida();
        
        if (health <= 0)
        {
            muerto = true;
        }

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
    }
    public void RevisarVida()
    {
        BarraVida.fillAmount = health / maxhealth;
    }
}
