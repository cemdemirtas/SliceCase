using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : setKnifeSpeed1
{
    public static KnifeMovement instance;
    public Rigidbody rb;
    public bool Ontouch;
    [SerializeField] GameObject trailEffect;

    #region Speed & angles
    float forwardSpeed = 1.5f;
    float UpSpeed = 4.5f;
    float X=5f;
    #endregion

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
            //rb.velocity = new Vector3(0, 4.5f, 1.5f); //Forward and up
            Move(forwardSpeed,UpSpeed);
            Rotate(X);
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

    public override void Move(float forwardSpeed, float upSpeed)
    {
        rb.velocity = new Vector3(0, upSpeed, forwardSpeed); //Forward and up
    }

    public override void Rotate(float X)
    {
        rb.angularVelocity = new Vector3(X, 0, 0); //Rotate around by X axis
    }
}
