using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("1st one", LoadSceneMode.Single);
    }
}
