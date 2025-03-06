using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewDishes", menuName = "CookingGame/Dishes")]
public class Dishes : ScriptableObject
{
    public List<GameObject> CoqauVinIngredients;
    public List<GameObject> tiramisuIngredients;
    public List<GameObject> dumplingsIngredients;
    public List<GameObject> shakshukaIngredients;
    public List<GameObject> churrosIngredients;


     public List<List<GameObject>> dishesList = new List<List<GameObject>>();
     public List<List<GameObject>> menuList = new List<List<GameObject>>();
    public Dictionary<List<GameObject>, string> dishNames = new Dictionary<List<GameObject>, string>();

    [SerializeField] private int score;



    public void InitializeMenu()
    {
        if (menuList.Contains(CoqauVinIngredients))
        {
            Debug.Log("Coqau Vin already added");
        }
        else
        {
            menuList.Add(CoqauVinIngredients);
            Debug.Log("Coqau Vin added to menuList.");
        }
    }


    public int ShowScore()
    {
        return score;
    }
    public void DeductScore(int value)
    {
        score -= value;
    }
    public void IncreaseScoree(int value)
    {
        score += value;
    }

    public void InitializeDishesList()
    {
        //ADD DISHES TO THE MENU HERE

        //dishesList.Clear(); // Ensure it's empty before adding elements
       // dishesList.Add(CoqauVinIngredients);
       // dishesList.Add(tiramisuIngredients);
       // dishesList.Add(dumplingsIngredients);
       // dishesList.Add(shakshukaIngredients);
       // dishesList.Add(churrosIngredients);

        // Map each list to its corresponding dish name
        dishNames[CoqauVinIngredients] = "Coq au Vin";
        dishNames[tiramisuIngredients] = "Tiramisu";
        dishNames[dumplingsIngredients] = "Dumplings";
        dishNames[shakshukaIngredients] = "Shakshuka";
        dishNames[churrosIngredients] = "Churros";
    }

    // Function to get the name of a dish based on its ingredients
    public string GetDishName(List<GameObject> ingredients)
    {
        if (dishNames.TryGetValue(ingredients, out string name))
        {
            return name;
        }
        return "Unknown Dish";
    }


    public bool ContainsTiramisu()
    {
        return dishesList.Contains(tiramisuIngredients);
    }


    public bool ContainsDumplings()
    {
        return dishesList.Contains(dumplingsIngredients);
    }


    public bool ContainsChurros()
    {
        return dishesList.Contains(churrosIngredients);
    }

    public bool ContainsShakshuka()
    {
        return dishesList.Contains(shakshukaIngredients);
    }







}