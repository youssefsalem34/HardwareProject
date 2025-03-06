using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DeepPan : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] private GameObject chickenPlaceHolder;
    [SerializeField] private GameObject chicken;
    [SerializeField] private bool chickenBool;
    [SerializeField] private int chickenCookingTime;

    [SerializeField] private GameObject eggPlaceHolder;
    [SerializeField] private GameObject egg;
    [SerializeField] private bool eggBool;
    [SerializeField] private int eggCookingTime;

    [SerializeField] private GameObject baconPlaceHolder;
    [SerializeField] private GameObject bacon;
    [SerializeField] private bool baconBool;
    [SerializeField] private int baconCookingTime;

    [SerializeField] private GameObject onionPlaceHolder;
    [SerializeField] private GameObject onion;
    [SerializeField] private bool onionBool;
    [SerializeField] private int onionCookingTime;

    [SerializeField] private Slider cookingSlider;

    void Start()
    {
        //chickenPlaceHolder.SetActive(false);
        //eggPlaceHolder.SetActive(false);
        //baconPlaceHolder.SetActive(false);
        //onionPlaceHolder.SetActive(false);

        chicken = Resources.Load("Cooked Chicken") as GameObject;
        // egg = Resources.Load("Cooked Egg") as GameObject;
        // bacon = Resources.Load("Cooked Bacon") as GameObject;
        // onion = Resources.Load("Cooked Onion") as GameObject;

        if (cookingSlider != null)
        {
            cookingSlider.gameObject.SetActive(false); // Hide slider initially
        }
    }

    void Update()
    {
        CheckForIngredients();
    }

    void CheckForIngredients()
    {
        Vector3 center = transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);

        foreach (Collider hitcol in hitColliders)
        {
            if (hitcol.gameObject.CompareTag("Chicken"))
            {
                Destroy(hitcol.gameObject);
                chickenBool = true;
                StartCoroutine(CookingChicken());
            }
            else if (hitcol.gameObject.CompareTag("Egg"))
            {
                Destroy(hitcol.gameObject);
                eggBool = true;
                StartCoroutine(CookingEgg());
            }
            else if (hitcol.gameObject.CompareTag("CutBacon"))
            {
                Destroy(hitcol.gameObject);
                baconBool = true;
                StartCoroutine(CookingBacon());
            }
            else if (hitcol.gameObject.CompareTag("CutOnion"))
            {
                Destroy(hitcol.gameObject);
                onionBool = true;
                StartCoroutine(CookingOnion());
            }
            else
            {
                Debug.Log("Cannot cook this.");
            }
        }
    }

    IEnumerator CookingChicken()
    {
        chickenPlaceHolder.SetActive(true);
        cookingSlider.gameObject.SetActive(true); // Show slider
        cookingSlider.maxValue = chickenCookingTime;
        cookingSlider.value = 0;

        float elapsedTime = 0;
        while (elapsedTime < chickenCookingTime)
        {
            elapsedTime += Time.deltaTime;
            cookingSlider.value = elapsedTime; // Update slider value
            yield return null;
        }

        cookingSlider.gameObject.SetActive(false); // Hide slider
        chickenPlaceHolder.SetActive(false);

        if (chickenBool)
        {
            Instantiate(chicken, chickenPlaceHolder.transform.position, Quaternion.identity);
        }
        chickenBool = false;
    }

    IEnumerator CookingEgg()
    {
        eggPlaceHolder.SetActive(true);
        cookingSlider.gameObject.SetActive(true); // Show slider
        cookingSlider.maxValue = eggCookingTime;
        cookingSlider.value = 0;

        float elapsedTime = 0;
        while (elapsedTime < eggCookingTime)
        {
            elapsedTime += Time.deltaTime;
            cookingSlider.value = elapsedTime; // Update slider value
            yield return null;
        }

        cookingSlider.gameObject.SetActive(false); // Hide slider
        eggPlaceHolder.SetActive(false);

        if (eggBool)
        {
            Instantiate(egg, eggPlaceHolder.transform.position, Quaternion.identity);
        }
        eggBool = false;
    }

    IEnumerator CookingBacon()
    {
        baconPlaceHolder.SetActive(true);
        cookingSlider.gameObject.SetActive(true); // Show slider
        cookingSlider.maxValue = baconCookingTime;
        cookingSlider.value = 0;

        float elapsedTime = 0;
        while (elapsedTime < baconCookingTime)
        {
            elapsedTime += Time.deltaTime;
            cookingSlider.value = elapsedTime; // Update slider value
            yield return null;
        }

        cookingSlider.gameObject.SetActive(false); // Hide slider
        baconPlaceHolder.SetActive(false);

        if (baconBool)
        {
            Instantiate(bacon, baconPlaceHolder.transform.position, Quaternion.identity);
        }
        baconBool = false;
    }

    IEnumerator CookingOnion()
    {
        onionPlaceHolder.SetActive(true);
        cookingSlider.gameObject.SetActive(true); // Show slider
        cookingSlider.maxValue = onionCookingTime;
        cookingSlider.value = 0;

        float elapsedTime = 0;
        while (elapsedTime < onionCookingTime)
        {
            elapsedTime += Time.deltaTime;
            cookingSlider.value = elapsedTime; // Update slider value
            yield return null;
        }

        cookingSlider.gameObject.SetActive(false); // Hide slider
        onionPlaceHolder.SetActive(false);

        if (onionBool)
        {
            Instantiate(onion, onionPlaceHolder.transform.position, Quaternion.identity);
        }
        onionBool = false;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}