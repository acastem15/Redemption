using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CogerObjeto : MonoBehaviour
{
    public GameObject handPoint;
    public GameObject mano; 
    public GameObject shield;
    public GameObject pickedObject =null; 
    private GameObject sphere = null;
    public  GameObject UIsphere;
    public GameObject panelFinal; 

    void Start() 
        {
            panelFinal.SetActive(false);
        }
    

    // Update is called once per frame
    void Update()
    {
        //Esfera movimiento 

        if (pickedObject != null)
        {
            if (Input.GetKey("q"))
            {
                pickedObject.SetActive(true);
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject.GetComponent<Rigidbody>().useGravity=true;
                pickedObject.GetComponent<Rigidbody>().isKinematic=false; 
                pickedObject.gameObject.transform.SetParent(null);
                pickedObject = null;
                shield.SetActive(true); 
                UIsphere.SetActive(false);
                
            } 
        }
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("object"))
        {
            
            if (Input.GetKey("e") && pickedObject == null)
            {                
                sphere = other.gameObject; 
                shield.SetActive(false); 
                UIsphere.SetActive(true);
                //other.GetComponent<CapsuleCollider>().radius=0.2f;
                //other.GetComponent<CapsuleCollider>().height=0.2f;
                //other.GetComponent<CapsuleCollider>().center=new Vector3(0f, 0f, 0f);
                handPoint.transform.position=mano.transform.position;
                other.GetComponent<Rigidbody>().useGravity=false; 
                other.GetComponent<Rigidbody>().isKinematic=true; 
                other.transform.position = handPoint.transform.position;

                other.gameObject.transform.SetParent(handPoint.gameObject.transform);

                pickedObject = other.gameObject; 
                pickedObject.SetActive(false);
                
            }
        }
        if (other.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene("N1");
        }

        
    }

}
