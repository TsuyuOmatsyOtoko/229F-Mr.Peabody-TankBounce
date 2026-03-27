using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoEndCredit : MonoBehaviour
{
    public GameObject winCanvas;
    public GameObject loseCanvas;
    public float waitTime = 5f;

    private bool timerStarted = false;
    private float timer = 0f;

    private void Update()
    {
        if ((winCanvas != null && winCanvas.activeSelf) || 
            (loseCanvas != null && loseCanvas.activeSelf))
        {
            if (!timerStarted)
            {
                timerStarted = true;
                timer = 0f;
            }

            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                SceneManager.LoadScene("Endcredit 1");
            }
        }
        
    }
}

