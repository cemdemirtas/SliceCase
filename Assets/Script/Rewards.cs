using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewards : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PointCalculator")
        {
            transform.GetComponent<BoxCollider>().isTrigger = false;
            KnifeMovement.instance.Ontouch = false;
            KnifeMovement.instance.rb.isKinematic = true;
            KnifeMovement.instance.transform.GetComponent<KnifeMovement>().enabled = false;

            float posY = KnifeMovement.instance.transform.position.y;
            if (posY >= 0 && posY <= 2)
            {
                Gold.Instance.Reward(1);
            }
            if (posY >= 2.1 && posY <= 4)
            {
                Gold.Instance.Reward(2);

            }
            if (posY >= 4.1 && posY <= 6)
            {
                Gold.Instance.Reward(3);

            }
            if (posY >= 6.1 && posY <= 8)
            {
                Gold.Instance.Reward(4);

            }
            if (posY >= 8.1 && posY < 10)
            {
                Gold.Instance.Reward(5);
            }
        }
}
}
