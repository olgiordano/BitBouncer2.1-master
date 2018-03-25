using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

    // Use this for initialization
    public void StartGame()
    {
        SceneManager.LoadScene("BasicScene");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
