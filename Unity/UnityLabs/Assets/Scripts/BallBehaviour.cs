using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float xRotation = 0;
    public float yRotation = 1f;
    public float zRotation = 0f;
    public float degRotationPerSecond = 180f;
    Color matColor;
    // Start is called before the first frame update
    void Start()
    {
        matColor = gameObject.GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 axis = new Vector3(xRotation, yRotation, zRotation);

        //Rotate around ball's centre
        //transform.Rotate(axis, degRotationPerSecond * Time.deltaTime);

        //Rotate the ball around a specific point
        transform.RotateAround(Vector3.zero, axis, degRotationPerSecond * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, axis, matColor,0.5f);
    }
}
