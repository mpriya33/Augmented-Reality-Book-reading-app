using Lean.Touch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Myscale : MonoBehaviour
{
    public GameObject Housemodel;
    public GameObject Housemodel1;
    public GameObject Housemodel2;
    public GameObject Housemodel3;
    private LeanPinchScale clkscale;
    private LeanPinchScale clkscale1;
    private LeanPinchScale clkscale2;
    private LeanPinchScale clkscale3;
    private Myrotate clkrotate1;
    private Myrotate clkrotate2;
    private Myrotate clkrotate3;
    private Myrotate clkrotate4;
    void Start()
    {
        clkscale = Housemodel.GetComponent<LeanPinchScale>();
        clkscale1 = Housemodel1.GetComponent<LeanPinchScale>();
        clkscale2 = Housemodel2.GetComponent<LeanPinchScale>();
        clkscale3 = Housemodel3.GetComponent<LeanPinchScale>();

        clkrotate1 = Housemodel.GetComponent<Myrotate>();
        clkrotate2 = Housemodel1.GetComponent<Myrotate>();
        clkrotate3 = Housemodel2.GetComponent<Myrotate>();
        clkrotate4 = Housemodel3.GetComponent<Myrotate>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved &&
            Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;



            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "salehouse1")
            {
                
                clkscale.enabled = true;
                clkscale1.enabled = false;
                clkscale2.enabled = false;
                clkscale3.enabled = false;

                clkrotate1.enabled = true;
                clkrotate2.enabled = false;
                clkrotate3.enabled = false;
                clkrotate4.enabled = false;


            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "salehouse2")
            {
                
                clkscale1.enabled = true;
                clkscale.enabled = false;
                clkscale2.enabled = false;
                clkscale3.enabled = false;

                clkrotate2.enabled = true;
                clkrotate1.enabled = false;
                clkrotate4.enabled = false;
                clkrotate3.enabled = false;

            }

            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "salehouse3")
            {

                clkscale1.enabled = false;
                clkscale.enabled = false;
                clkscale2.enabled = true;
                clkscale3.enabled = false;

                clkrotate2.enabled = false;
                clkrotate1.enabled = false;
                clkrotate4.enabled = false;
                clkrotate3.enabled = true;

            }
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "salehouse4")
            {

                clkscale1.enabled = false;
                clkscale.enabled = false;
                clkscale2.enabled = false;
                clkscale3.enabled = true;

                clkrotate2.enabled = false;
                clkrotate1.enabled = false;
                clkrotate4.enabled = true;
                clkrotate3.enabled = false;

            }


            else
            {
                clkscale1.enabled = false;
                clkscale.enabled = false;
                clkscale2.enabled = false;
                clkscale3.enabled = false;
                
          
                clkrotate1.enabled = false;
                clkrotate2.enabled = false;
                clkrotate3.enabled = false;
                clkrotate4.enabled = false;

            }



        }




    }
}
