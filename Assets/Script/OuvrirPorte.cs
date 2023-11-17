using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{

    [SerializeField] GameObject PorteDroite;
     [SerializeField] GameObject PorteGauche;
     [SerializeField] GameObject Joeur;
  
    void Start()
    {
        Debug.Log(PorteDroite);
        Debug.Log(PorteGauche);
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player"){
        PorteDroite.GetComponent<Animator>().SetBool("Ouvre",true);

        if(other.tag =="Player"){
        PorteGauche.GetComponent<Animator>().SetBool("Ouvre",true);

        }
        }
    }

    private void OnTriggerExit(Collider other)
    {
            if(other.tag =="Player"){
        PorteDroite.GetComponent<Animator>().SetBool("Ouvre",false);
    } if(other.tag =="Player"){
        PorteDroite.GetComponent<Animator>().SetBool("Ouvre",false);
    }
}
}