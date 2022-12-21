using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toMain : MonoBehaviour
{
    public GameObject st;
   public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void buttonRemove(){
        st.SetActive(false);
    }
}
