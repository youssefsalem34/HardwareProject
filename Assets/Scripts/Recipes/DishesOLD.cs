using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class DishesOLD : MonoBehaviour
{
    public Dishes dishScript;
    [SerializeField] private TMP_Text dishText;

    public List<GameObject> selectedIngredients = new List<GameObject>();
    public bool newDish;

    private void Start()
    {
        dishScript.InitializeMenu();
        dishScript.InitializeDishesList();
        newDish = false;
        GetRandomDishIngredients();
    }

    private void Update()
    {
        if (newDish)
        {
            selectedIngredients.Clear();
            GetRandomDishIngredients();
            newDish = false;
        }
    }


    //Picks which recipe to get next
    public List<GameObject> GetRandomDishIngredients()
    {
        if (dishScript == null)
        {
            Debug.LogWarning("Dishes ScriptableObject is not assigned!");
            return selectedIngredients;
        }

        int randomIndex = Random.Range(0, dishScript.menuList.Count);
        List<GameObject> randomList = dishScript.menuList[randomIndex];

        selectedIngredients.AddRange(randomList);

        // Update the dishText with the name of the selected dish
        string dishName = dishScript.GetDishName(randomList);
        UpdateCurrentDishText(dishName);

        Debug.Log("Selected ingredients: " + string.Join(", ", selectedIngredients));
        return selectedIngredients;
    }

    private void UpdateCurrentDishText(string dishName)
    {
        if (dishText != null)
        {
            dishText.text = $" {dishName}:";
        }
    }
}