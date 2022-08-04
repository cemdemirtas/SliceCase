using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : MonoBehaviour
{
    public static KnifeMovement instance;
    public Rigidbody rb;
    public bool Ontouch;
    [SerializeField] GameObject trailEffect;
    private void Start()
    {
        rb=GetComponent<Rigidbody>();
        BeginStatus();
    }
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Ontouch==false)
        {
            //when we click right button, set trail active
            Ontouch = true;
            trailEffect.SetActive(true);
            rb.isKinematic = false;
            rb.velocity=new Vector3 (0,4.5f,1.5f); //Forward and up
            rb.angularVelocity=new Vector3 (5,0,0); //Rotate around by X axis
        }
        else if (Input.GetMouseButtonUp(0))
        {
         Ontouch=false;
        }
    }
    void BeginStatus()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
