using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    private Scene currentScene;
    private string sceneName;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        Cursor.visible = false;
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) && sceneName == "TitleScreen")
        {
            StartGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && (sceneName == "Level 01" || sceneName == "Finish"))
        {
            TitleScreen();
        }

        if (Input.GetKeyDown(KeyCode.R) && sceneName == "Finish")
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 01");   //carrega cena de gameplay após start
    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Finish");
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }


}
