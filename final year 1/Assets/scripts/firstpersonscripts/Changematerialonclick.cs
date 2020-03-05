using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changematerialonclick : MonoBehaviour
{
    public Material[] materialarr;
    public Material[] materialarr1;
    private Renderer render;
    private int count = 1;
    string Value;
    string valuename;
    GameObject obj;

    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
       
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                Value = Hit.transform.tag;
                valuename = Hit.transform.name;
                obj = GameObject.Find(valuename);
                render = obj.GetComponent<Renderer>();
                render.enabled = true;

                if (materialarr.Length == 0)
                {
                    return;
                }
                if (materialarr1.Length == 0)
                {
                    return;
                }
                if (Value == "myhousewalls")
                {
                    
                    count += 1;
                    if (count == materialarr.Length + 1)
                    {
                        count = 1;
                    }

                    print(count);
                    render.sharedMaterial = materialarr[count - 1];

                }

                if (Value=="myhousefloors")
                {
                    count += 1;
                    if (count == materialarr1.Length + 1)
                    {
                        count = 1;
                    }

                    print(count);
                    render.sharedMaterial = materialarr1[count - 1];
                }
            }
        }
    }

   

}
