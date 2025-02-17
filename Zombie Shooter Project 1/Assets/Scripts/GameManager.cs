﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public GameObject gameOverUI;

    public SceneFader_01 sceneFader;

    public void LevelMenu()
    {
        //SceneFader.instance.LoadLevel("Level Menu");
        sceneFader.FadeTo("Level Menu");
    }

    public void StartGame()
    {
       // SceneFader.instance.LoadLevel("Zombie Shooter Level 1");
        //SceneManager.LoadScene("Zombie Shooter Level 1");
        //PlayerPrefs.SetInt("playerCurrentLife", playerLife);
    }

    // starts level 2
    public void StartLevel2()
    {
        //SceneFader.instance.LoadLevel("Zombie Shooter Level 2");
        //SceneManager.LoadScene("Zombie Shooter Level 1");
        //PlayerPrefs.SetInt("playerCurrentLife", playerLife);
    }

    // goes to the win scene
    public void WinGame()
    {
        //SceneFader.instance.LoadLevel("Game Win");
        Debug.Log("Level Won!");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }

    // goes to the game over scene
    public void EndGame()
    {
        //SceneManager.LoadScene("Game Over");
        //SceneFader.instance.LoadLevel("Game Over");
        //sceneFader.FadeTo("Game Over");

        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    //returns to main menu
    public void BackToMainMenu()
    {
        sceneFader.FadeTo("Main Menu");
    }

    public void ControlsMenu()
    {
        sceneFader.FadeTo("Controls Menu");
    }

    public void OptionsMenu()
    {
        sceneFader.FadeTo("Options Menu");
    }

    // restarts the level
    public void RestartGame()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    // goes to the tutorial level
    public void tutorialLevel()
    {
        //SceneManager.LoadScene("Test Tutorial Level (Dialogue Change)");
        //SceneFader.instance.LoadLevel("Tutorial Level");
    }
    

    // closes the application
    public void ExitGame()
    {
        Application.Quit();
    }

}
