using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void PlayGame()
    {
        Debug.Log("PlayGame Clicked");
        Cursor.visible = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("ExitGame Clicked");
        Application.Quit();
    }
}
