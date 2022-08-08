using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class KnifeMovement : setKnifeSpeed1
{
    public static KnifeMovement instance;
    public Rigidbody rb;
    public bool Ontouch;
    [SerializeField] GameObject trailEffect;

    #region Speed & angles
    float forwardSpeed = 2.5f;
    float UpSpeed = 4.5f;
    float X=10f;
    float rotateSpeed = 1;
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
            Move(forwardSpeed ,UpSpeed);
            Rotate(X * rotateSpeed);
            //Rotate(3.14f );
            //Rotate(X * rotateSpeed);
            //transform.rotation = Quaternion.Lerp(Quaternion.identity, targetpos, Time.deltaTime);
            //transform.DORotate(new Vector3(359.003204f, 8.2255125f, 169.937439f), 2).OnStepComplete(() =>Rotate(X));
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Ontouch = false;
            rb.isKinematic = false;

            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;

            //Quaternion targetpos = new Quaternion(15f, 8.2255125f, 169.937439f, 1);
            //transform.rotation = targetpos;

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
