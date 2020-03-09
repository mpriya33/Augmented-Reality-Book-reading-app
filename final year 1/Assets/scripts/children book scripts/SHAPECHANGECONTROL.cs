using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using UnityEngine.UI;
public class SHAPECHANGECONTROL : MonoBehaviour
{
    public GameObject object1;
    private LeanDragDeformMesh treewithoutbranches;
    void Start()
    {
        treewithoutbranches = object1.GetComponent<LeanDragDeformMesh>();
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

        treewithoutbranches.enabled = false;

    }

}
