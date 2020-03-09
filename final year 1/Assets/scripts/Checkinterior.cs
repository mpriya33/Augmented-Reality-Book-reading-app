using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkinterior : MonoBehaviour
{
    private GameObject interior;
    void Start()
    {
        interior = GameObject.Find("interior");
        
    }


    public void Yes()
    {
        SceneManager.LoadScene("first person interior", LoadSceneMode.Single);

    }

    public void No()
    {
        interior.SetActive(false);
    }
}
