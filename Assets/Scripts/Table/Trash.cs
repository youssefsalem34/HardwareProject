using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Trash : MonoBehaviour
{
    [SerializeField] private float radius;
    string[] validTags = { "Chicken", "CookedChicken", "CookedEgg", "CutCarrot", "CookedOnion", "CutCabbage", "CutOnion", "CookedBacon", "CookedDough", "RedWine", "Carrots", "Salt", "Pepper", "Onion", "Sugar", "Egg", "Bacon", "CocoaPowder", "Coffee", "Tomatoe", "CutBacon", "Coriander", "Parsley", "BellPepper", "Water", "Cabbage", "Dough", "SoySauce", "GreenOnions", "Garlic", "Ginger", "Biscuits" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyIngredients();
    }

    //void OnTriggerEnter(Collider collider)
    //{
    //    Destroy(collider.gameObject);
    //}


    void DestroyIngredients()
    {
        Vector3 center = transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, radius); // Get all colliders in the sphere

        // Loop through the colliders and check for matching ingredients
        foreach (Collider hitcol in hitColliders)
        {
            if (validTags.Contains(hitcol.gameObject.tag))
            {
                Destroy(hitcol.gameObject);
            }
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
