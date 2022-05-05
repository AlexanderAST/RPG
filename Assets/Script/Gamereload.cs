using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamereload : MonoBehaviour
{

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.P))
        {
            SceneManager.LoadScene("Game");
        }
    }

} 
