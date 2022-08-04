using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Plane")
        {
            KnifeMovement.instance.rb.velocity = Vector3.zero;
            KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            KnifeMovement.instance.rb.isKinematic = true;
        }
        if (other.gameObject.tag == "Slicable")
        {
            //whether knife hit slicable objects, cut of them
            other.GetComponent<Slicable>().Slice(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}