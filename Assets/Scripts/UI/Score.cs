using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scireDisplay;
    [SerializeField] private TMP_Text timerDisplay;
    [SerializeField] private GameObject pauseBackground;
    [SerializeField] private GameObject lose;
    [SerializeField] private int score;
    [SerializeField] private GameObject shop;


    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject customizeButton;
    [SerializeField] private GameObject customize;
    [SerializeField] private GameObject tiramisuCube;
    [SerializeField] private GameObject dumplingCube;
    [SerializeField] private GameObject churrosCube;
    //public int timer;
    public float time;


    private void Update()
    {
        
        DisplayListContents();
        time = time - Time.deltaTime;
        UpdateTimerDisplay();
        TimerDone();



    }
    public int CheckScore()
    {
        return score;
    }


    //Clicking on play to restart the game
    public void RestartScene()
    {
        SceneManager.LoadScene(1);
        tiramisuCube.SetActive(false);
        dumplingCube.SetActive(false);
        churrosCube.SetActive(false);
    }
    //Click on shop to open the shop UI
    public void OpenShop()
    {
        shop.SetActive(true);
        shopButton.SetActive(false);
        customizeButton.SetActive(false);
    }
    public void OpenMenu()
    {
        customize.SetActive(true);
        shopButton.SetActive(false);
        customizeButton.SetActive(false);
    }




    public void TimerDone()
    {
        //Timer ending and player losing the game conditions here
        if(time <= 0)
        {
            Time.timeScale = 0;
            pauseBackground.SetActive(true);
            lose.SetActive(true);
            shopButton.SetActive(true);
            customizeButton.SetActive(true);
        }
        else{
            Time.timeScale = 1;
        }
    }
    public void IncreaseScore(int value)
    {
        score += value;
    }
    public void DecreaseScore(int value)
    {
        score -= value;
    }

    void DisplayListContents()
    {
        scireDisplay.text =  score.ToString();
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(time / 60); // Calculate minutes
        int seconds = Mathf.FloorToInt(time % 60); // Calculate seconds
        timerDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Display in "MM:SS" format
    }
}
