using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public GameObject ui;
    public GameObject objecttoteleport;
    public Transform teleportlocation;

    void Start()
    {
        ui.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if ((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            objecttoteleport.transform.position = teleportlocation.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
    }

}
