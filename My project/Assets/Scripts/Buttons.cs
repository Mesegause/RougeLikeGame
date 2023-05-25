using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private int buildIndexSceneGame = 1;
    private int buildIndexSceneRecords = 2;
    private int buildIndexSceneExit = 3;

    public void StartGame()
    {
        SceneManager.LoadScene(buildIndexSceneGame);
    }

    public void Records()
    {
        SceneManager.LoadScene(buildIndexSceneRecords);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(buildIndexSceneExit);
    }
}
