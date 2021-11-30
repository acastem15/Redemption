using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spike_combate : MonoBehaviour
{
    public int maxhealth;
    public float health;
    public int dano = 2;
    public Image BarraVida;
    public Animator anime; 
    public CantidadMuertos muertos;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }
    void Update()
    {
        RevisarVida();
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
    public void RevisarVida()
    {
        BarraVida.fillAmount = health / maxhealth;
    }
}
