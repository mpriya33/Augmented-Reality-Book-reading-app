using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myrotate2 : MonoBehaviour
{
    public float rotationSpeed1 = 180f;
    private bool isHit=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            float rotationX = Input.GetAxis("Mouse X") * rotationSpeed1 * Mathf.Deg2Rad;
            transform.Rotate(Vector3.down, -rotationX, Space.World);
           
        }
        else
        {
            
        }
       

    }

    public void Beenhit1()
    {
        isHit = true;
    }


}
