using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deathscript : MonoBehaviour
{
   void OnTriggerEnter( Collider col)
    {
        if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

   

   
}
