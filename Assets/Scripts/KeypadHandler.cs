using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;

public class KeypadHandler : MonoBehaviour
{
    
    public string answer;
    public GameObject player;
    public Animator door;
    public TMP_InputField inputfield;
    public GameObject maincanvas;

    void Start()
    {
        door.enabled = false;

    }

    public void Exit()
    {
        maincanvas.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnSubmitted()
    {
        if (inputfield.text == answer){
            door.enabled = true;
            Debug.Log("Door Fired");
            Exit();
        } else {
            inputfield.text = "";
        }
    }
}
