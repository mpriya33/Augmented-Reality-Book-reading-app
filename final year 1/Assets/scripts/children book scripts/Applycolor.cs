using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Applycolor : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    public Material material;
    void Start()
    {
        material.color = fcp.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
