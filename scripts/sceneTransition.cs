using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour
{

    public void LoadGame()
    {
        SceneManager.LoadScene("playGame");
    }

    public void loadHelpScene()
    {
        SceneManager.LoadScene("helpScene");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("main menu");
    }
}
