using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	public GameObject Menu;
    private bool paused;

    private void Awake()
    {
        Menu.SetActive(false);
    }

    private void Start()
    {
        paused = Menu.activeInHierarchy;
    }

    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
            paused = !paused;
			if(paused == true) {
                Time.timeScale = 0.0f;
                Menu.SetActive(true);
			}
			else {
                Time.timeScale = 1.0f;
                Menu.SetActive(false);
			}
		}
	}

    public void ButtonSys(string what)
    {
        if(what == "Resume")
        {
            Time.timeScale = 1.0f;
            Menu.SetActive(false);
        }
        else if (what == "Restart")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (what == "Quit")
        {
            Application.Quit();
            Debug.Log("Game has closed!");
        }
        else if (what == "Settings")
        {
            Debug.Log("Placeholder Text"); // 
        }
    }
    // blah blah blah
}
