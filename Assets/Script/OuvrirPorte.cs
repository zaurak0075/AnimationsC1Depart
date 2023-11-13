using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{

    [SerializeField] GameObject porteDroite;
     [SerializeField] GameObject PorteGauche;
     [SerializeField] GameObject Joeur
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(porteDroite);
        Debug.Log(PorteGauche);
    }

     void OnTriggerEnter(Collider other)
    {
        
    }

}
