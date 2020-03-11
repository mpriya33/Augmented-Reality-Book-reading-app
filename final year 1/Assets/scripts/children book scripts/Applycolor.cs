using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Applycolor : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public Material[] material;

    public Color externalColor;
    private Color internalColor;

    private void Start()
    {
        internalColor = externalColor;
    }

    private void Update()
    {
        //apply color of this script to the FCP whenever it is changed by the user
        if (internalColor != externalColor)
        {
            fcp.color = externalColor;
            internalColor = externalColor;
        }

        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        if (hitInfo.transform.gameObject.tag == "treewithoutleaves")
        {
            //extract color from the FCP and apply it to the object material
            material[0].color = fcp.color;
        }

        if (hitInfo.transform.gameObject.tag == "leaves")
        {
            
            material[1].color = fcp.color;
        }
        if (hitInfo.transform.gameObject.tag == "grass")
        {
            
            material[2].color = fcp.color;
        }
        if (hitInfo.transform.gameObject.tag == "rock")
        {

            material[3].color = fcp.color;
        }


    }
}
