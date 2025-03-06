using UnityEngine;



public class WinLose : MonoBehaviour
{
    [SerializeField] private  UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    [SerializeField] private GameObject pauseBackground;
    [SerializeField] private GameObject scoreObject;
    [SerializeField] private GameObject lose;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject restart;
    [SerializeField] private Score score;
    [SerializeField] private Dishes dishesScript;
    [SerializeField] private int scoreRequiredToWin;

    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject customizeButton;

    private bool scoreConditionMet; // Flag to track if the score condition is already processed

    void Start()
    {
        scoreConditionMet = false;
       // pauseBackground.SetActive(false);
        score = scoreObject.GetComponent<Score>();
    }

    void Update()
    {
        CheckIfScoreEnough();
    }
    //Win condition
    void CheckIfScoreEnough()
    {
        if (score.CheckScore() >= scoreRequiredToWin && !scoreConditionMet) // Only proceed if score condition is met and not already processed
        {
            scoreConditionMet = true; // Set the flag to prevent re-execution

            Time.timeScale = 0; // Pause the game
            pauseBackground.SetActive(true); // Show pause background
            win.SetActive(true); // Display win screen
            shopButton.SetActive(true);
            customizeButton.SetActive(true);
            if (interactable != null)
            {
                interactable.enabled = false;
            }
            // shop.SetActive(true); // Enable next level UI button

            dishesScript.IncreaseScoree(score.CheckScore()); // Increase the score only once
        }
        //Lose condition is inside the Score script which can be found on the Canvas 
       
    }
}