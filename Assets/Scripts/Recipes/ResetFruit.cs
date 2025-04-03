using UnityEngine;

public class ResetFruit : MonoBehaviour
{
    [SerializeField] private Dishes dishesScript;
    [SerializeField] private Score scoreScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void ResetScoreAndRecipes()
    {
        if (dishesScript.fruitDone == true)
        {
            scoreScript.ScoreReset(0);
            dishesScript.Clear();
        }
    }
}
