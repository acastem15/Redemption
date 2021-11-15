using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador_Controlador_N2 : MonoBehaviour
{
    public CharacterController controlador;

    public Transform camara;
    public float velocidad = 6f;

    public float giro_tiempo = 0.1f;

    float giro_velocidad;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camara.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref giro_velocidad, giro_tiempo);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controlador.Move(moveDirection.normalized * velocidad * Time.deltaTime);
        }

    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        Debug.Log (collisionInfo.collider.name);
    }
}

