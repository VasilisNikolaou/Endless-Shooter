using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraShake : MonoBehaviour
{
    private Transform trans;

    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.7f;
    private float dampingSpeed = 1.0f;

    Vector3 initialPosition;

    private void Awake()
    {
        if (trans == null)
            trans = GetComponent(typeof(Transform)) as Transform;
    }

    private void OnEnable()
    {
        initialPosition = transform.localPosition;
    }

    private void Update()
    {
        if(shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

    public void TriggerShake()
    {
        shakeDuration = .4f;
    }

}
