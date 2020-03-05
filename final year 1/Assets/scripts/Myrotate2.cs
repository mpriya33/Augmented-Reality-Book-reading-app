using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myrotate2 : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)] float lerpTime;
    [SerializeField] Vector3[] myangles;

    int angleindex;
    int len;
    float t=0f;
    
    void Start()
    {
        len = myangles.Length;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(myangles[angleindex]), lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if (t > .9f)
        {
            t = 0f;
            angleindex = Random.Range(0, len - 1);
        }
    }


}
