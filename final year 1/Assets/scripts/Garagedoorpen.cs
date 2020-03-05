using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garagedoorpen : MonoBehaviour
{
    public GameObject test;
    private Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1 = test.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved &&
            Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "garagedoor")
            {
                anim1.Play("garagedoor");
             
            }
        }
    }
}
