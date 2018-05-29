using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject sound;

    public GameObject ui;

    public GameObject aeon;

    

    void Start()
    {
        sound.SetActive(false);
        ui.SetActive(false);
    }

    
    
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            sound.SetActive(true);
            ui.SetActive(true);
            aeon.GetComponent<Animator>().SetBool("scannen", true);
        }else
        {
            aeon.GetComponent<Animator>().SetBool("scannen", false);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sound.SetActive(false);
            ui.SetActive(false);
            aeon.GetComponent<Animator>().SetBool("scannen", false);
            
        }
    }
}
