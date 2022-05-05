using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (this.CompareTag("Player") && other.CompareTag("EndGame"))
        {
            SceneManager.LoadScene("End");
        }

    }
}
