using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
