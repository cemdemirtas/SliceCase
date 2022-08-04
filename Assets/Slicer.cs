using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicer : MonoBehaviour
{
    IInterract ýnterract;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Plane")
        {
            KnifeMovement.instance.rb.velocity = Vector3.zero;
            KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            KnifeMovement.instance.rb.isKinematic = true;
            KnifeMovement.instance.Ontouch = false;

        }
        if (other.TryGetComponent( out IInterract interract))
        {
            //whether knife hit slicable objects, cut of them
            other.GetComponent<Slicable>().interract(other.gameObject);
            KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            Destroy(other.gameObject);

        }
        if (other.gameObject.tag == "Slicable")
        {
        }
    }
}