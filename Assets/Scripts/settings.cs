using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    public string scenename;

    public void PlayScenetwo()
    {
        SceneManager.LoadScene(2);
    }
}
