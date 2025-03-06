using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class OuterFloor : MonoBehaviour
{

    string[] validTags = { "Chicken", "CookedChicken", "CookedEgg", "CutCarrot", "CookedOnion", "CutCabbage", "CutOnion", "CookedBacon", "CookedDough", "RedWine", "Carrots", "Salt", "Pepper", "Onion", "Sugar", "Egg", "Bacon", "CocoaPowder", "Coffee", "Tomatoe", "CutBacon", "Coriander", "Parsley", "BellPepper", "Water", "Cabbage", "Dough", "SoySauce", "GreenOnions", "Garlic", "Ginger", "Biscuits" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (validTags.Contains(col.gameObject.tag))
        {
            Destroy(col.gameObject);
        }
    }
}
