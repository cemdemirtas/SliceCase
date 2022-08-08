using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerOfKnife : MonoBehaviour
{
    [SerializeField]Rigidbody rb;
    private void Start()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag =="Slicable")
        {
            StartCoroutine(Tab(other.gameObject));
        }
    }
    IEnumerator Tab(GameObject obj)
    {
        obj.gameObject.GetComponent<BoxCollider>().isTrigger = false;
        rb.angularVelocity = new Vector3(10f, 0, 0);
        rb.velocity = new Vector3(0, 2, -2);
        Debug.Log("run lower");
        yield return new WaitForSeconds(0.2f);
    }
}
