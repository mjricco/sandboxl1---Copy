using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBlock : MonoBehaviour
{

    public float damageToDeal;
    private bool db;

    // Start is called before the first frame update
    void Start()
    {
        db = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && db == false) 
        {
            db = true;
            other.gameObject.GetComponent<PlayerHealth>().health = other.gameObject.GetComponent<PlayerHealth>().health - damageToDeal;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player") 
        {
            db = false;
        }
    }
}

