using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathquestion : MonoBehaviour
{
    private GameObject correct1;
    private GameObject wrong1;
    private GameObject question1;
    private GameObject question2;
    private GameObject question3;
    private GameObject question4;
    private GameObject replay;
    string Value;
    void Start()
    {

        correct1 = GameObject.Find("Correctmath");
        wrong1 = GameObject.Find("Wrongmath");
        correct1.SetActive(false);
        wrong1.SetActive(false);

        
        question1 = GameObject.Find("question1");

        question2 = GameObject.Find("question2");
        question2.SetActive(false);

        question3 = GameObject.Find("question3");
        question3.SetActive(false);

        question4 = GameObject.Find("question4");
        question4.SetActive(false);

        replay = GameObject.Find("replay");
        replay.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                Value = Hit.transform.name;
                if (Value == "q1answer1")
                {
                    wrong1.SetActive(true);
                    correct1.SetActive(false);
                    StartCoroutine(Removedaftertime(3, wrong1));
                    
                }

                else if (Value == "q1answer2")
                {
                    wrong1.SetActive(false);
                    correct1.SetActive(true);
                    StartCoroutine(Removedaftertime(3, correct1));
                    question2.SetActive(true);
                    question1.SetActive(false);
                   
                   
                    
                }
                else if (Value == "q2answer1")
                {
                    wrong1.SetActive(false);
                    correct1.SetActive(true);
                    StartCoroutine(Removedaftertime(3, correct1));
                    question2.SetActive(false);
                    question3.SetActive(true);
                }

                else if (Value == "q2answer2")
                {
                    wrong1.SetActive(true);
                    correct1.SetActive(false);
                    StartCoroutine(Removedaftertime(3, wrong1));
                  
                }
                
                else if (Value == "q3answer1")
                {
                    wrong1.SetActive(true);
                    correct1.SetActive(false);
                    StartCoroutine(Removedaftertime(3, wrong1));
                }

                else if (Value == "q3answer2")
                {
                    wrong1.SetActive(false);
                    correct1.SetActive(true);
                    StartCoroutine(Removedaftertime(3, correct1));
                    question3.SetActive(false);
                    question4.SetActive(true);
                }

                else if (Value == "q4answer1")
                {
                    wrong1.SetActive(true);
                    correct1.SetActive(false);
                    StartCoroutine(Removedaftertime(3, wrong1));
                }

                else if (Value == "q4answer2")
                {
                    wrong1.SetActive(false);
                    correct1.SetActive(true);
                    StartCoroutine(Removedaftertime(3, correct1));
                    question4.SetActive(false);
                    replay.SetActive(true);
                    
                }

                else if(Value == "replay")
                {
                    replay.SetActive(false);
                    question1.SetActive(true);
                }


            }
           
        }

        IEnumerator Removedaftertime(int seconds, GameObject obj)
        {
            yield return new WaitForSeconds(2);
            obj.SetActive(false);
        }

        
    }
}
