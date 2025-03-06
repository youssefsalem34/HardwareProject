using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{
    [SerializeField] private TMP_Text totalText;
    [SerializeField] private Dishes scoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreDisplay();
    }


    private void UpdateScoreDisplay()
    {
        totalText.text = "Tokens: " + scoreScript.ShowScore(); // Display the score
    }
}
