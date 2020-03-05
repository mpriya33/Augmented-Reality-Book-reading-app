using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myrotate3 : MonoBehaviour
{
    [SerializeField] float rotationspeed = 100f;
    bool dragging = false;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        dragging = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
        
    }
    private void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationspeed;
            rb.AddTorque(Vector3.down*x);
        }
    }

}
