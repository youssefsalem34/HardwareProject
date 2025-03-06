using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class CheckIngredients : MonoBehaviour
{
    [SerializeField] private float radius;
    public List<GameObject> ingredientsOnPlate;
    public  List<GameObject> otherList;
    [SerializeField] private GameObject currentDishObject;
    [SerializeField] private DishesOLD currentDish;
    public GameObject button;

    [SerializeField] private int pointsPerDish;
    [SerializeField] private int losePerBan;
    [SerializeField] private GameObject ui;
    [SerializeField] private Score uiScore;
    [SerializeField] private GameObject missingText;

    [SerializeField] private AudioSource audioSource;
   

    [SerializeField] private PickCustomer customerCheck;
    private int gameScore;

    string[] validTags = { "Chicken", "CookedChicken", "CookedEgg", "CutCarrot","CookedOnion", "CutCabbage", "CutOnion", "CookedBacon", "CookedDough", "RedWine", "Carrots", "Salt", "Pepper", "Onion", "Sugar", "Egg", "Bacon", "CocoaPowder", "Coffee", "Tomatoe", "CutBacon", "Coriander", "Parsley", "BellPepper", "Water", "Cabbage", "Dough", "SoySauce", "GreenOnions", "Garlic", "Ginger", "Biscuits" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ui = GameObject.Find("Canvas");
        uiScore = ui.GetComponent<Score>();
        currentDish = currentDishObject.GetComponent<DishesOLD>();
        otherList = currentDish.selectedIngredients;
        missingText.SetActive(false);



    
    }

    // Update is called once per frame
    void Update()
    {
        CheckForIngredients();
       
       // Debug.Log("Lists are equal: " + aretheyEqual);
    }


    public void CheckIfIngredientsCorrect()
    {
        bool aretheyEqual = CompareGameObjectLists(otherList, ingredientsOnPlate);
        // Correct ingredients 
        if (aretheyEqual)
        {
            if(customerCheck.isBanned != true)
            {
                foreach (GameObject ing in ingredientsOnPlate)
                {
                    Destroy(ing.gameObject);
                    uiScore.IncreaseScore(pointsPerDish);
                }
                currentDish.newDish = true;
                audioSource.Play();

                button.transform.localPosition = new Vector3(0, 0.43f, 0);
                missingText.SetActive(false);
            }
            else if(customerCheck.isBanned == true)
            {
                foreach (GameObject ing in ingredientsOnPlate)
                {
                    Destroy(ing.gameObject);
                    uiScore.DecreaseScore(losePerBan);
                }
                currentDish.newDish = true;

                button.transform.localPosition = new Vector3(0, 0.43f, 0);
                missingText.SetActive(false);
            }
           


        }
        else if(!aretheyEqual)
        {
            //If the player did not add the correct ingredients, add text here
            missingText.SetActive(true);
        }
    }

  
    public void ButtonOut()
    {
        button.transform.localPosition = new Vector3(0, 0.76f, 0);
    }


    bool CompareGameObjectLists(List<GameObject> listA, List<GameObject> listB)
    {
        // Check if both lists have the same number of elements
        if (listA.Count != listB.Count)
            return false;

        // Sort lists by tag to ensure they are in the same order
        var sortedListA = listA.OrderBy(gameObj => gameObj.tag).ToList();
        var sortedListB = listB.OrderBy(gameObj => gameObj.tag).ToList();

        // Compare the tags of each GameObject in the sorted lists
        for (int i = 0; i < sortedListA.Count; i++)
        {
            if (sortedListA[i].tag != sortedListB[i].tag)
                return false;
        }

        return true;
    }
    void CheckForIngredients()
    {
        ingredientsOnPlate.Clear();
        Vector3 center = transform.position; // Center of the OverlapSphere (this object’s position)
        Collider[] hitColliders = Physics.OverlapSphere(center, radius); // Get all colliders in the sphere

        // Loop through the colliders and check for matching ingredients
        foreach (Collider hitcol in hitColliders)
        {
            // Check if the object has the correct tag or some other identification
            if (validTags.Contains(hitcol.gameObject.tag)) // Check if the object's tag is in the list
            {
                //Only add if the ingredient is not already in the list
                if (!ingredientsOnPlate.Contains(hitcol.gameObject))
                {
                    ingredientsOnPlate.Add(hitcol.gameObject); // Add to the list if it matches the tag
                }

            }
    }
   // Define a list of tags


}


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
