using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGameSinglePlayer()
    {
        Debug.Log("Game vs AI started!");
        SceneManager.LoadScene("PongSingle");
        
    }

    public void StartGameMultiPlayer()
    {
        Debug.Log("Game vs Player started!");
        SceneManager.LoadScene("PongMulti");
    }

    public void QuitGame()
    {
        Debug.Log("Game quit!");
        Application.Quit();
    }
}
