using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPush : MonoBehaviour
{
    [SerializeField]
    private float forceMagnitude;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;
        if(rigidbody != null && hit.gameObject.tag != "NPC")
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y= 0;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection * forceMagnitude, transform.position, ForceMode.Impulse);
        }
    }
}
