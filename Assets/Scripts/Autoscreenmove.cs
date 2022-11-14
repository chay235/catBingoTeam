using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Autoscreenmove : MonoBehaviour
{
    private float timer = 9f;
    private float timeElapsed;
    void update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > timer)
        {
            SceneManager.LoadScene("PlayerScene");
        }
    }
}
