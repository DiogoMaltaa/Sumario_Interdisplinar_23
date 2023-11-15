using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [Header("Rotate")]
    public Vector3 rotation;
    public float speed;

    [Header("Floating")]
    public float speedFloat;
    public float height;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(rotation * speedFloat * Time.deltaTime);


        float newY = Mathf.Sin(Time.time * speedFloat) * height * initPos.y;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
