using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_combate : MonoBehaviour
{
    public int health;
    public int dano;
    public Barra_Vida_Logica BVL;
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
            BVL.vida_actual -= dano;
            BVL.vida_actual -= health;
        }

        if (health <= 0)
        {
            muertos.cantidad += 1;
            Destroy(gameObject);
            
        }
    }
}
