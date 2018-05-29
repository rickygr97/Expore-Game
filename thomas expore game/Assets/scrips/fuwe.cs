using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuwe : MonoBehaviour
{
    public GameObject sound;

    public GameObject camara;

    public GameObject maincamara;

    public GameObject tutrle;

    void Start()
    {
        tutrle.SetActive(false);

        camara.SetActive(false);

        sound.SetActive(false);
    }



    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            tutrle.SetActive(true);
            camara.SetActive(true);
            maincamara.SetActive(false);
            sound.SetActive(true);
            camara.GetComponent<Animator>().SetBool("camaraaction", true);
            tutrle.GetComponent<Animator>().SetBool("camaraation", true);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tutrle.SetActive(false);
            camara.SetActive(false);
            maincamara.SetActive(true);
            sound.SetActive(false);
            camara.GetComponent<Animator>().SetBool("camaraaction", false);

        }
    }
}
