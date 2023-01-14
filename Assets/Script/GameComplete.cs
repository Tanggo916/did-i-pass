using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameComplete : MonoBehaviour
{

    public GameObject gameCompleteMenu;
    public GameObject gameCompleteLevel;

    private void OnEnable()
    {
        ScoreManager.OnPlayerEnd += EnableGameCompleteMenu;
        ScoreManager.OnPlayerComplete += EnableGameCompleteLevel;
    }

    private void OnDisable()
    {
        ScoreManager.OnPlayerEnd -= EnableGameCompleteMenu;
        ScoreManager.OnPlayerComplete -=EnableGameCompleteLevel;
    }
    public void EnableGameCompleteMenu()
    {
        gameCompleteMenu.SetActive(true);

    }

    public void EnableGameCompleteLevel()
    {

        gameCompleteLevel.SetActive(true);
    }
}
