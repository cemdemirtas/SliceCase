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
    public event EventManager.LevelLoseDelegate LevelLoseEvent;

    private void Start()
    {
        rb=GetComponent<Rigidbody>();
        BeginStatus();
        LevelLoseEvent += LevelFailure;
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
            Move(forwardSpeed ,UpSpeed);
            Rotate(X * rotateSpeed);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Ontouch = false;
            rb.isKinematic = false;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "Failure")
        {
            LevelLoseEvent?.Invoke();
        }
    }
    void LevelFailure()
    {
    Debug.Log("failure");
    }
}
