using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.AI;
using Vector3 = UnityEngine.Vector3;

public class Enemigi_controlador : MonoBehaviour
{
    public NavMeshAgent navMesh;

    public GameObject Knight;
    public ParticleSystem DestroyedEffect;
    
    public bool Destroyed => m_Destroyed;

    bool m_Destroyed = false;
    float m_CurrentHealth;

    public float health = 2.0f;
    public AudioClip Hit = null;

    void Awake() 
    {
        
        navMesh = GetComponent<NavMeshAgent>();

    }

    void Start()
    {
      m_CurrentHealth = health;
    }
    void Update() 
    {
        if(navMesh.enabled)
        {
            float dist = Vector3.Distance(Knight.transform.position, this.transform.position);
            
        }
    }

    public void Got(float damage)
    {
        m_CurrentHealth -= damage;
        
        if(m_CurrentHealth > 0)
            return;

        Vector3 position = transform.position;
        m_Destroyed = true;
        
        gameObject.SetActive(false);
    }

    
}