using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barra_vida : MonoBehaviour
{
    public int healthMax = 20;
    public int healthActual;
    public Image ImagenBarraVida;
    public Jugador_combate Knight;

    // Start is called before the first frame update
    void Start()
    {
        healthActual = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();
    }
    public void RevisarVida()
    {
        ImagenBarraVida.fillAmount = healthActual / healthMax;
    }
}
