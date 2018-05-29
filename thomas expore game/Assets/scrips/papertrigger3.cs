using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class papertrigger3 : MonoBehaviour
{
    public GameObject sound;

    public GameObject ui;

    public GameObject image;

    public GameObject aeon;



    void Start()
    {
        ui.SetActive(false);
        image.SetActive(false);
        sound.SetActive(false);
    }



    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            ui.SetActive(true);
            image.SetActive(true);
            sound.SetActive(true);
            aeon.GetComponent<Animator>().SetBool("scannen", true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ui.SetActive(false);
            image.SetActive(false);
            sound.SetActive(false);
            aeon.GetComponent<Animator>().SetBool("scannen", false);

        }
    }
}
