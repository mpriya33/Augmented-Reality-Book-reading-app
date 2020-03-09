using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescript : MonoBehaviour
{
    private Touch touch;
    private float speedmodifier;
    string a;

    void Start()
    {
        speedmodifier = 0.01f;
        a = gameObject.tag;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            string tag = hitInfo.transform.gameObject.tag;
            if (touch.phase== TouchPhase.Moved)
            {
                if (tag==a)
                {
                    transform.position = new Vector3(
                   transform.position.x + touch.deltaPosition.x * speedmodifier,
                   transform.position.y,
                   transform.position.z + touch.deltaPosition.y * speedmodifier);
                }
               
            }
           
        }
    }
}
