using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecthavelockmodel : MonoBehaviour
{
    private Text labelhead;
    private Text labeltext;
    private Text labelhead1;
    private Text labeltext1;
    private GameObject BG;
     public GameObject model;

   // private Myrotate somescript;

    void Start()
    {
        //labelhead = GameObject.Find("UI heading").GetComponent<Text>();
        // labelhead.text = "";

        // labeltext = GameObject.Find("UI text").GetComponent<Text>();
        // labeltext.text = "";
        labelhead = GameObject.Find("UIheading").GetComponent<Text>();
        labelhead.gameObject.SetActive(false);

        labeltext = GameObject.Find("UItext").GetComponent<Text>();
        labeltext.gameObject.SetActive(false);

        BG = GameObject.Find("BGUI");
        BG.SetActive(false);

       
        labelhead1 = GameObject.Find("UIheading1").GetComponent<Text>();
        labelhead1.gameObject.SetActive(false);

        labeltext1 = GameObject.Find("UItext1").GetComponent<Text>();
        labeltext1.gameObject.SetActive(false);

        //somescript = model.GetComponent<Myrotate>();
        


    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit)&& hit.collider.gameObject.tag=="build1")
            {
                
                    BG.SetActive(true);
                    labelhead.gameObject.SetActive(true);
                    labeltext.gameObject.SetActive(true);
                //somescript.enabled = false;



            }
           
            else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "build2")
            {

                BG.SetActive(true);
                labelhead1.gameObject.SetActive(true);
                labeltext1.gameObject.SetActive(true);
                //somescript.enabled = false;
            }
           
            else
            {
 
                BG.SetActive(false);
                labelhead.gameObject.SetActive(false);
                labeltext.gameObject.SetActive(false);
                labelhead1.gameObject.SetActive(false);
                labeltext1.gameObject.SetActive(false);
                //somescript.enabled = true;
            }





        }

#elif UNITY_ANDROID

        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && 
        Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
           
           

         if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag =="build1")
            {
                
                BG.SetActive(true);
                labelhead1.gameObject.SetActive(true);
                labeltext1.gameObject.SetActive(true);
                labelhead.gameObject.SetActive(false);
                labeltext.gameObject.SetActive(false);
                //somescript.enabled = false;

            }
        else if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag=="build2")
           {

               
       
                BG.SetActive(true);
                labelhead.gameObject.SetActive(true);
                labeltext.gameObject.SetActive(true);
                labelhead1.gameObject.SetActive(false);
                labeltext1.gameObject.SetActive(false);
                //somescript.enabled = false;
                
            }
            else
            {
                BG.SetActive(false);
                labelhead1.gameObject.SetActive(false);
                labeltext1.gameObject.SetActive(false);
                labelhead.gameObject.SetActive(false);
                labeltext.gameObject.SetActive(false);
                //somescript.enabled = true;

            }



        }

#endif

    }
}
