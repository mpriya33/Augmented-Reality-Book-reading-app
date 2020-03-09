using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garagedoorpen : MonoBehaviour
{
    
    public AudioSource audio1;
    private GameObject interiorpopup;
    public GameObject test;
    private Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        audio1.enabled = false;
        anim1 = test.GetComponent<Animator>();
        interiorpopup = GameObject.Find("interior");
        interiorpopup.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved &&
            Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "garagedoor")
            {
                audio1.enabled = true;
                anim1.Play("garagedoor");
                audio1.Play();
                StartCoroutine(Appliedaftertime(10, interiorpopup));
                

            }
        }
    }

    IEnumerator Appliedaftertime(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(true);
    }
}
