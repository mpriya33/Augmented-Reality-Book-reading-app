using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Havelockvbscript : MonoBehaviour,IVirtualButtonEventHandler
{
    VirtualButtonBehaviour vrb;

    // Start is called before the first frame update
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour>();
        vrb.RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://havelockcity.lk/");
       // Application.OpenURL("tel://+940714449160");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("pressed");
    }

   
}
