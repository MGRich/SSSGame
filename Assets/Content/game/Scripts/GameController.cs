using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject pauseIndicator;

    void Awake()
    {
		bool paused = Input.GetKey(KeyCode.P);
		if (paused)
		{
			Time.timeScale = 0f;
			AudioListener.pause = true;
			pauseIndicator.SetActive(true);
		}
		else
		{
			pauseIndicator.SetActive(false);
			Time.timeScale = 1f;
			AudioListener.pause = false;
		}
    }

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RestartLevel();
        }
    }*/ // Replaced this with escape menu;

    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            Time.timeScale = 0f;
            AudioListener.pause = true;
            pauseIndicator.SetActive(true);
        }
        else
        {
            pauseIndicator.SetActive(false);
            Time.timeScale = 1f;
            AudioListener.pause = false;
        }
    }

    public void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
