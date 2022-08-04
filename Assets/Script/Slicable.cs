using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slicable : MonoBehaviour
{
    [SerializeField] GameObject HalfObject; //Two side of object which has seperated right & left

    public void Slice(GameObject obj)
    {
        GameObject instantiatedGameObject=Instantiate(HalfObject,obj.transform.position,obj.transform.rotation);
        //instantiatedGameObject.transform.SetParent(obj.transform);

        //Force right and left side
        foreach (Transform getChild in instantiatedGameObject.transform)
        {
            if (getChild.gameObject.tag=="right")
            {
                getChild.gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * 5f;
            }
            if (getChild.gameObject.tag=="left")
            {
                getChild.gameObject.GetComponent<Rigidbody>().velocity = Vector3.left * 5f;
            }
        }
    }
}
