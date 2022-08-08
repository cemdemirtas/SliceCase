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
            KnifeMovement.instance.Ontouch = false;
            //KnifeMovement.instance.rb.velocity = Vector3.zero;
            //KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            KnifeMovement.instance.rb.isKinematic = true;
        }
        if (other.TryGetComponent(out IInterract interract))
        {
            KnifeMovement.instance.rb.velocity = Vector3.down * 5; //slice speed
            KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            //KnifeMovement.instance.rb.velocity = Vector3.zero;
            Gold.Instance.takeGold(10);
            //whether knife hit slicable objects, cut of them
            other.GetComponent<Slicable>().interract(other.gameObject);
            //KnifeMovement.instance.rb.angularVelocity = Vector3.zero;
            Destroy(other.gameObject);
        }


        }
    }