using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selecthavtest : MonoBehaviour
{
    
    void Start()
    {
        //labelhead = GameObject.Find("UI heading").GetComponent<Text>();
        // labelhead.text = "";

        // labeltext = GameObject.Find("UI text").GetComponent<Text>();
        // labeltext.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
           
            





        }
#elif UNITY_ANDROID

        if((Input.GetTouch(0).phase==TouchPhase.Stationary)||(Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
         RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                hit.collider.gameObject.GetComponent<Hit1>().Beenhit();
               
                


            }
        }

#endif

    }
}

