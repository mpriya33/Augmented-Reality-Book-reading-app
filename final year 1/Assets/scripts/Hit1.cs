using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit1 : MonoBehaviour
{
    private Text labelhead;
    private Text labeltext;
    private GameObject BG;
   

    private bool isHit;
    void Start()
    {
        isHit = false;

        labelhead = GameObject.Find("UIheading").GetComponent<Text>();
        labelhead.gameObject.SetActive(false);

        labeltext = GameObject.Find("UItext").GetComponent<Text>();
        labeltext.gameObject.SetActive(false);

        BG = GameObject.Find("BGUI");
        BG.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            BG.SetActive(true);
            labelhead.gameObject.SetActive(false);
            labeltext.gameObject.SetActive(false);
        }

        else
        {
            BG.SetActive(false);
            labelhead.gameObject.SetActive(false);
            labeltext.gameObject.SetActive(false);
        }

        
    }

   public void Beenhit()
    {
        isHit=true;
    }
}
