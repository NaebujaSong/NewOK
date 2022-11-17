using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1to2 : MonoBehaviour
{
    // void LoadSceneAdditive()
    // {
    //     SceneManager.LoadScene("Opening2", LoadSceneMode.Additive);
    //     SceneManager.SetActiveScene(SceneManager.GetSceneByName("Opening2"));
    // }

    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space))
    //     {
    //         LoadSceneAdditive();
    //     }
    // }
    public void ChangeScene()
    {
        SceneManager.LoadScene("Opening2");
    }

}