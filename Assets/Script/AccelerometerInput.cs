using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput : MonoBehaviour
{
    public float smooth = 0.4f;
    float newRotation;
    public float sensitivity = 1;
    private Vector3 currentAcceleration, initialAcceleration;
    void Start()
    {
        initialAcceleration = Input.acceleration;
        currentAcceleration = Vector3.zero;
    }

    void Update()
    {
        //pre-processing

        currentAcceleration = Vector3.Lerp(currentAcceleration, Input.acceleration - initialAcceleration, Time.deltaTime / smooth);

        newRotation = Mathf.Clamp(currentAcceleration.x * sensitivity, -9, 9);
        transform.Translate(newRotation, 0, 0);
    }
}
