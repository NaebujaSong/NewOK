using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMain : MonoBehaviour
{
   public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
