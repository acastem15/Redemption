using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_Controlador : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform jugador;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(jugador.position);
    }
}
