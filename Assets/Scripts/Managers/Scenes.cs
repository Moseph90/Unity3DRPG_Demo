using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;

public class Scenes : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
    public Button mainMenuButton;
    public Button continueButton;
    public Button loadButton;

    public GameObject pauseMenu;

    private Scenes Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = GetComponent<Scenes>();
        Time.timeScale = 1f;

        if (startButton) startButton.onClick.AddListener(StartGame);
        if (quitButton) quitButton.onClick.AddListener(QuitGame);
        if (mainMenuButton) mainMenuButton.onClick.AddListener(MainMenu);
        if (continueButton) continueButton.onClick.AddListener(Pause);
        if (loadButton) loadButton.onClick.AddListener(StartGame);

        if (SceneManager.GetActiveScene().name == "GameScene")
            Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pauseMenu) return;
        if (Input.GetKeyUp(KeyCode.P))
            Pause();
    }

    private void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("MenuClick");
        if (SceneManager.GetActiveScene().name != "GameScene")
        {
            SceneManager.LoadScene("GameScene");
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("MenuClick");
        GameManager.Instance.Quit();
    }

    private void MainMenu()
    {
        FindObjectOfType<AudioManager>().Play("MenuClick");
        if (SceneManager.GetActiveScene().name != "MainMenu")
        {
            SceneManager.LoadScene("MainMenu");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public static void GameOver()
    {
        Debug.Log("GameOver function reached");
        Cursor.lockState = CursorLockMode.None;
        GameOverInvoke();
    }
    private static void GameOverInvoke()
    {
        Debug.Log("GameOverInvoke reached");
        if (SceneManager.GetActiveScene().name != "GameOver")
        {
            SceneManager.LoadScene("GameOver");
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void Pause()
    {
        FindObjectOfType<AudioManager>().Play("Pause");
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        if (pauseMenu.activeSelf)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
