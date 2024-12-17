using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    public Animator door;
    private int total;
    private bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        door.enabled = false;
        isOpen = true;
        total = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        total = total + 1;
    }

    private void OnTriggerExit(Collider other)
    {
        total = total - 1;
    }

    void Update()
    {
        // if (door.isPlaying)
        // {
        //    return;
        // }
        if (isOpen && total == 0)
        {
            isOpen = false;
            door.Play("DoorOpen");
        }
        if ((!isOpen) && total > 0)
        {
            door.enabled = true;
            isOpen = true;
            door.Play("DoorClose");
        }
    }
}
