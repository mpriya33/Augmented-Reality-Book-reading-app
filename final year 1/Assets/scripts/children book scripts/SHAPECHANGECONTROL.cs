using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using UnityEngine.UI;
public class SHAPECHANGECONTROL : MonoBehaviour
{
    int a;
    public GameObject[] objects;
    private LeanDragDeformMesh treewithoutbranches;
    private LeanDragDeformMesh leaves;
    private LeanDragDeformMesh grass;
    private LeanDragDeformMesh rock;
    //private Movescript[] movearr;
    private LeanDragTranslate leavemove;
    private Movescript movearr1;
    private Movescript movearr2;
    private Movescript movearr3;
    void Start()
    {
        a = 0;
        treewithoutbranches = objects[0].GetComponent<LeanDragDeformMesh>();
        leaves = objects[1].GetComponent<LeanDragDeformMesh>();
        grass = objects[2].GetComponent<LeanDragDeformMesh>();
        rock = objects[3].GetComponent<LeanDragDeformMesh>();
        treewithoutbranches.enabled = false;
        leaves.enabled = false;
        grass.enabled = false;

        // movearr[0]= objects[0].GetComponent<Movescript>();
        //movearr[1] = objects[1].GetComponent<Movescript>();
        //movearr[2] = objects[2].GetComponent<Movescript>();
        movearr1 = objects[0].GetComponent<Movescript>();
        movearr2 = objects[2].GetComponent<Movescript>();
        movearr3 = objects[3].GetComponent<Movescript>();
        leavemove = objects[1].GetComponent<LeanDragTranslate>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change()
    {
        //RaycastHit hitInfo = new RaycastHit();
        //bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

        //if (hitInfo.transform.gameObject.tag == "salehouse1")
        //{

        //}
        a += 1;
        if (a == 1)
        {
            
            treewithoutbranches.enabled = true;
            leaves.enabled = true;
            grass.enabled = true;

            //movearr[0].enabled = false;
            //movearr[1].enabled = false;
            //movearr[2].enabled = false;
            movearr1.enabled = false;
            movearr2.enabled = false;
            movearr3.enabled = false;
            leavemove.enabled = false;

        }
        if (a == 2)
        {
            treewithoutbranches.enabled = false;
            leaves.enabled = false;
            grass.enabled = false;

            //movearr[0].enabled = true;
            //movearr[1].enabled = true;
            //movearr[2].enabled = true;

            movearr1.enabled = true;
            movearr2.enabled = true;
            movearr3.enabled = true;
            leavemove.enabled = true;

            a = 0;
        }




    }

}
