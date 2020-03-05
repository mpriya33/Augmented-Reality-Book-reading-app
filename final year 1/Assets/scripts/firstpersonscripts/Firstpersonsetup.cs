using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Firstpersonsetup : MonoBehaviour
{
    public FixedJoystick Movejoystick;
    public FixedTouchField Touchfield;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.Runaxis = Movejoystick.Direction;
        fps.mouseLook.Lookaxis = Touchfield.TouchDist;
    }
}
