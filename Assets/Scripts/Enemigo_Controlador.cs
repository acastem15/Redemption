using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo_Controlador : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform jugador;
    public LayerMask detect_ground, detect_player;

    // Patroling
    public Vector3 walkpoint;
    bool walkpointSet;
    public float walkpointRange;

    //Attack
    public float timebetweenattacks;
    bool alreadyAttacked;
    public GameObject proyectil;

    //States
    public float sightRange, attackRange;
    public bool playerinsightRange, playerinattackRange;

    // Update is called once per frame
    private void Awake()
    {
        jugador = GameObject.Find("Knight").transform; 
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        //playerinsightRange = Physics.CheckSphere(transform.position, sightRange, detect_player);
        //playerinattackRange = Physics.CheckSphere(transform.position, attackRange, detect_player);

        if(!playerinsightRange && !playerinattackRange) Patroling();
        if(playerinsightRange && !playerinattackRange) ChasePlayer();
        //if (playerinsightRange && playerinattackRange) AttackPlayer();
    }

    private void Patroling()
    {
        if(!walkpointSet) SearchWalkPoint();

        if(walkpointSet){
            agent.SetDestination(walkpoint);}

        Vector3 distanceToWalkPoint = transform.position - walkpoint;

        //Walkpoint reached
        if(distanceToWalkPoint.magnitude < 1f){
            walkpointSet = false;}
    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkpointRange, walkpointRange);
        float randomX = Random.Range(-walkpointRange, walkpointRange);

        walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walkpoint, -transform.up, 2f, detect_ground)){
        walkpointSet = true;}
    }

    private void ChasePlayer()
    {
        agent.SetDestination(jugador.position);
    }

    //private void AttackPlayer()
    //{
        //Enemy doesn't move
        //agent.SetDestination(transform.position);
        //transform.LookAt(jugador);

        //if(!alreadyAttacked){
            
            //Attack code
            //Rigidbody rb = Instantiate(proyectil, transform.position, Quaternion.identity).GetComponent<RigidBody>();
            //rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            //rb.AddForce(transform.up * 8f, ForceMode.Impulse);
            
            
            //alreadyAttacked = true;
            //Invoke(nameof(ResetAttack), timebetweenattacks);
        //}
        //private void ResetAttack()
    //{
        //alreadyAttacked = false;
    //}


}
