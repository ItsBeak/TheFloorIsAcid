using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] m_Characters;
    public GameObject[] m_Buttons;

    public enum GameState
    {
        Start,
        Playing,
        GameOver
    };

    private GameState m_GameState;
    public GameState State
    {
        get
        {
            return m_GameState;
        }
    }

    private void Awake()
    {
        m_GameState = GameState.Start;
    }

    // Start is called before the first frame update
    void Start()
    {
       // for (int i = 0; i < m_Characters.Length; i++)
       // {
       //     m_Characters[i].SetActive(false);
       // }

    }

    // Update is called once per frame
    void Update()
    {
        //SWITCHES BETWEEN GAMESTATES
        switch (m_GameState)
        {
            case GameState.Start:
                //DIFFERENT FOR MOBILE BUT MAY CHANGE TO MENU/SCENE

                m_GameState = GameState.Playing;

                for (int i = 0; i < m_Characters.Length; i++)
                {
                    m_Characters[i].SetActive(true);
                }


                break;
            case GameState.Playing:
                bool isGameOver = false;

                if (IsPlayerDead() == true)
                {
                    isGameOver = true;
                }

                if (IsBlueButtonPressed() == true)
                {
                    isGameOver = true;
                }

                if (isGameOver == true)
                {
                    //m_GameState = GameState.GameOver;

                    //

                    if (IsPlayerDead() == true)
                    {
                        SceneManager.LoadScene("GameOver");
                    }
                    else if (IsBlueButtonPressed() == true)
                    {
                        SceneManager.LoadScene("WinScreen");
                    }
                }
                break;
            case GameState.GameOver:
                for (int i = 0; i < m_Characters.Length; i++)
                {
                    m_Characters[i].SetActive(false);
                }

                //CHANGE SCENE
                //SceneManager.LoadScene("gameOver");

                //NOT SURE IF NEEDED ANYMORE BECAUSE OF CHANGE SCENE
                //if (Input.GetKeyUp(KeyCode.Return) == true)
                //{
                //    m_GameState = GameState.Playing;
                //    //
                //
                //    for (int i = 0; i < m_Characters.Length; i++)
                //    {
                //        m_Characters[i].SetActive(true);
                //    }
                //}
                break;
        }

        //QUIT OR PAUSE NOT SURE IF CHANGE SCENE
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    //CHECKS IF PLAYER IS DEAD
    private bool IsPlayerDead()
    {
        for (int i = 0; i < m_Characters.Length; i++)
        {
            if (m_Characters[i].activeSelf == false)
            {
                if (m_Characters[i].tag == "Player")
                    return true;
            }
        }

        return false;
    }

    //CHECKS IF BLUE BUTTON IS PRESSED
    private bool IsBlueButtonPressed()
    {
        if (m_Buttons[0].activeSelf == false && m_Buttons[1].activeSelf == false)
        {
            return true;
        }
        return false;
    }

    //CODE FOR NEW GAME BUTTON
    public void OnNewGame()
    {
        //

        m_GameState = GameState.Playing;
        //

        for (int i = 0; i < m_Characters.Length; i++)
        {
            m_Characters[i].SetActive(true);
        }
    }
}
