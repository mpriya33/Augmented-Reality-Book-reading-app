using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotateview : MonoBehaviour
{
    public GameObject house;
    int a;
    void Start()
    {
        a = 0;
        house = GameObject.Find("salehouse3");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Rotateclick()
    {
        a += 1;
       
        if (a == 1)
        {
            house.transform.Rotate(new Vector3(90, 0, 0));
        }
        if (a == 2)
        {
            house.transform.Rotate(new Vector3(0, 180, 0));
        }

        if (a == 3)
        {
            house.transform.Rotate(new Vector3(90, 0, 0));
            a = 0;
        }

        if (a == 4)
        {
            house.transform.Rotate(new Vector3(0, 0, 0));
            //a = 1;
        }

    }


}
