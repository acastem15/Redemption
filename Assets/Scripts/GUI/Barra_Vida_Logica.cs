using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Barra_Vida_Logica : MonoBehaviour
{
    public int vidaMax;
    public float vida_actual;
    public Image barra_vida_imagen;
    
    // Start is called before the first frame update
    void Start()
    {
        vida_actual = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        Revisar_Vida();
        if(vida_actual <= 0)
        {
            gameObject.SetActive(false);
        }
    }
   
    public void Revisar_Vida()
    {
        barra_vida_imagen.fillAmount = vida_actual / vidaMax;
    }

}
