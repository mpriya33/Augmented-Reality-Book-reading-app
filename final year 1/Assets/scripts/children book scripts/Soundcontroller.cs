using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundcontroller : MonoBehaviour
{
    public AudioClip[] audiotunes;
    public AudioSource Mysource;
    string Btnname;
    string[] arr = new string[] { "pianobtn", "guitarbtn" };
    private GameObject correct1;
    private GameObject wrong1;
    bool one;
    bool two;
    bool three;
    bool four;
    void Start()
    {
        Mysource = GetComponent<AudioSource>();
        correct1 = GameObject.Find("Correct");
        wrong1 = GameObject.Find("Wrong");
        correct1.SetActive(false);
        wrong1.SetActive(false);
        one = false;
        two = false;
        three = false;
        four = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                Btnname = Hit.transform.name;
                switch (Btnname)
                {
                    case "pianobtn":
                        Mysource.clip = audiotunes[0];
                        Mysource.Play();
                        one = true;
                        two = false;
                        three = false;
                        four = false;
                        break;
                    case "guitarbtn":
                        Mysource.clip = audiotunes[1];
                        Mysource.Play();
                        two = true;
                        three = false;
                        four = false;
                        break;
                    case "drumsbtn":
                        Mysource.clip = audiotunes[2];
                        Mysource.Play();
                        three = true;
                        four = false;
                        break;
                    case "trumpetbtn":
                        Mysource.clip = audiotunes[3];
                        Mysource.Play();
                        four = true;
                        break;
                    default:
                        break;
                }


                if (one)
                {
                    
                    if (two)
                    {

                        if (three)
                        {
                            if (four)
                            {
                                correct1.SetActive(true);
                               
                            }

                        }
                        
                    }

                   
                }

            }

            else
            {
                Mysource.Pause();
                correct1.SetActive(false);
            }

        }


    }
}
