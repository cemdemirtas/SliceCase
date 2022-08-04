using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChase : MonoBehaviour
{
    [SerializeField] private float smoothness;
    [SerializeField] private Transform KnifeTransform;

    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(transform.position.x, KnifeTransform.position.y + 1.5f, KnifeTransform.position.z);
        Vector3 SmoothPos = Vector3.Lerp(transform.position, targetPos, smoothness * Time.deltaTime);
        transform.position = SmoothPos;
    }
}
