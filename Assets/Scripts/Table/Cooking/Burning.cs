using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;


public class Burning : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] private float chickenBurnTime;
    [SerializeField] private float eggBurnTime;
    [SerializeField] private float baconBurnTime;
    [SerializeField] private float onionBurnTime;

    [SerializeField] private GameObject spawnPosition;

    [SerializeField] private GameObject burntChicken;
    [SerializeField] private bool chickenBurning = false;

    [SerializeField] private GameObject burntEgg;
    [SerializeField] private bool eggBurning = false;

    [SerializeField] private GameObject burntBacon;
    [SerializeField] private bool baconBurning = false;

    [SerializeField] private GameObject burntOnion;
    [SerializeField] private bool onionBurning = false;

    [SerializeField] private GameObject nullObject;

    [SerializeField] private bool burningStop;

    [SerializeField] private Slider cookingSlider;


    public Collider[] hitColliders;

    List<string> validTags = new List<string> { "CookedChicken", "CookedEgg", "CookedBacon", "CookedOnion" };

    void Start() 
    {
    
    }

    void Update()
    {
        BurningFood();

        //if (nullObject == null)
        //{
            

        //    burningStop = true;
        //    Debug.Log("No items Burning");
        //}


        if (burningStop)
        {
            cookingSlider.gameObject.SetActive(false);
        }
    }

    void BurningFood()
    {
        Array.Clear(hitColliders, 0, hitColliders.Length);
        Vector3 center = transform.position;
         hitColliders = Physics.OverlapSphere(center, radius);


        foreach (Collider hitcol in hitColliders)
        {
            // Check if the object has the correct tag or some other identification
            if (!validTags.Contains(hitcol.gameObject.tag)) // Check if the object's tag is in the list
            {
                burningStop = true;
            }
            else
            {
                burningStop = false;
            }
            
        }

        foreach (Collider hitcol in hitColliders)
        {
            //while loop to check whether hitColliders has been cleared. If clear change a bool to true. 
            if (hitcol.gameObject.CompareTag("CookedChicken") && !chickenBurning)
            {
                chickenBurning = true;
                StartCoroutine(StartBurning(hitcol.gameObject, chickenBurnTime, burntChicken, "chicken"));
            }
            else if (hitcol.gameObject.CompareTag("CookedBacon") && !baconBurning)
            {
                baconBurning = true;
                StartCoroutine(StartBurning(hitcol.gameObject, baconBurnTime, burntBacon, "bacon"));
            }
            else if (hitcol.gameObject.CompareTag("CookedOnion") && !onionBurning)
            {
                onionBurning = true;
                StartCoroutine(StartBurning(hitcol.gameObject, onionBurnTime, burntOnion, "onion"));
            }
            else if (hitcol.gameObject.CompareTag("CookedEgg") && !eggBurning)
            {
                eggBurning = true;
                StartCoroutine(StartBurning(hitcol.gameObject, eggBurnTime, burntEgg, "egg"));
            }
        }
    }

    IEnumerator StartBurning(GameObject cookedObject, float burnTime, GameObject burntPrefab, string type)
    {
        if (cookingSlider == null)
        {
            Debug.LogWarning("Cooking slider is not assigned!");
            yield break;
        }

        cookingSlider.gameObject.SetActive(true);
        cookingSlider.maxValue = burnTime;
        cookingSlider.value = 0;

        float elapsedTime = 0;
        while (elapsedTime < burnTime)
        {
            elapsedTime += Time.deltaTime;
            cookingSlider.value = elapsedTime;
            yield return null;
        }
        if (!burningStop)
        {
            cookingSlider.gameObject.SetActive(false);
            Instantiate(burntPrefab, spawnPosition.transform.position, Quaternion.identity);
            Destroy(cookedObject);
        }
        else
        {
            cookingSlider.gameObject.SetActive(false);
        }

        //BurnTheFood();
        // Reset the burning state after completion
        switch (type)
        {
            case "chicken": chickenBurning = false; break;
            case "bacon": baconBurning = false; break;
            case "onion": onionBurning = false; break;
            case "egg": eggBurning = false; break;
        }
    }



    void BurnTheFood()
    {
      
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
