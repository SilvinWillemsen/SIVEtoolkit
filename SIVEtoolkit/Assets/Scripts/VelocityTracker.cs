using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityTracker : MonoBehaviour
{

    private Vector3 prevPosition;
    private Vector3 curVelocity;

    // Start is called before the first frame update
    void Start()
    {
        prevPosition = transform.position;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        curVelocity = (transform.position - prevPosition) / Time.fixedDeltaTime;
        prevPosition = transform.position;
    }

    public Vector3 getVelocity()
    {
        return curVelocity;
    }
}
