using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Score.score = 0;
        SceneManager.LoadScene("PlayScene");

    }

    public void EndGame()
    {
        Score.score = 0;
        SceneManager.LoadScene("MainMenu");

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
