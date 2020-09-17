using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] m_Characters;

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
        for (int i = 0; i < m_Characters.Length; i++)
        {
            m_Characters[i].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        switch (m_GameState)
        {
            case GameState.Start:
                if (Input.GetKeyUp(KeyCode.Return) == true) // different for mobile?
                {
                    //
                    m_GameState = GameState.Playing;

                    for (int i = 0; i < m_Characters.Length; i++)
                    {
                        m_Characters[i].SetActive(true);
                    }
                }
                break;
            case GameState.Playing:
                bool isGameOver = false;

                if (IsPlayerDead() == true)
                {
                    isGameOver = true;
                }

                if (isGameOver == true)
                {
                    m_GameState = GameState.GameOver;

                    //

                    if (IsPlayerDead() == true)
                    {
                        //
                    }
                    else
                    {
                        //
                    }
                }
                break;
            case GameState.GameOver:
                for (int i = 0; i < m_Characters.Length; i++)
                {
                    m_Characters[i].SetActive(false);
                }

                if (Input.GetKeyUp(KeyCode.Return) == true)
                {
                    m_GameState = GameState.Playing;
                    //

                    for (int i = 0; i < m_Characters.Length; i++)
                    {
                        m_Characters[i].SetActive(true);
                    }
                }
                break;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();//change to pause?
        }
    }

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
