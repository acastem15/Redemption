using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_control : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;


    private void Update()
    {
       agent.SetDestination(player.position);
    }
}
