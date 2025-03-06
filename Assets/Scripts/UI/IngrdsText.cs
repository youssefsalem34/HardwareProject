using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System.Linq;

public class IngrdsText : MonoBehaviour
{
    [SerializeField] private GameObject currentDish;
    [SerializeField] private DishesOLD currentDishScript;
    [SerializeField] private TMP_Text tmpText;

    public List<GameObject> list;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentDish = GameObject.Find("CurrentDish");
        currentDishScript = currentDish.GetComponent<DishesOLD>();
        tmpText = GetComponent<TMP_Text>();
        list = currentDishScript.selectedIngredients;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayListContents();
    }

    void DisplayListContents()
    {
        // Join the names of ingredients in the list with newline characters
        string displayText = string.Join("\n", list.Select(ingredient => ingredient.name));

        // Set the text to the TMP component
        tmpText.text = displayText;
    }
}
