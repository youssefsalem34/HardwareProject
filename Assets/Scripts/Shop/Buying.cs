using UnityEngine;

public class Buying : MonoBehaviour
{
    [SerializeField] private GameObject shopButton;
    [SerializeField] private GameObject customizeButton;
    [SerializeField] private GameObject customize;

    [SerializeField] private Dishes dishScript;
    [SerializeField] private int tiramisuPrice;
    [SerializeField] private int dumplingsPrice;
    [SerializeField] private int shakshukaPrice;
    [SerializeField] private int churrosPrice;
    [SerializeField] private GameObject shop;
   // [SerializeField] private Dishes scriptable;


    [SerializeField] private GameObject tiramisuCube;
    [SerializeField] private GameObject dumplingCube;
    [SerializeField] private GameObject churrosCube;
    [SerializeField] private GameObject shakshukaCube;



    [SerializeField] private CustomizeMenu menuScript;


    [SerializeField] private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
        if(dishScript.ContainsTiramisu())
        {
            tiramisuCube.SetActive(false);
        }
        else
        {
            tiramisuCube.SetActive(true);
        }

        if (dishScript.ContainsDumplings())
        {
            dumplingCube.SetActive(false);
        }
        else
        {
            dumplingCube.SetActive(true);
        }

        if (dishScript.ContainsChurros())
        {
            churrosCube.SetActive(false);
        }
        else
        {
            churrosCube.SetActive(true);
        }


        if (dishScript.ContainsShakshuka())
        {
            shakshukaCube.SetActive(false);
        }
        else
        {
            shakshukaCube.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dishScript.dishesList);
    }

    public void BuyingTiramisu()
    {
        if(dishScript.ShowScore() >= tiramisuPrice)
        {
            Debug.Log("Tiramisu Bought");
            //Deducting the cost of tiramisu recipe from the overall score in the scriptable object Dishes
            dishScript.DeductScore(tiramisuPrice);
             // Add tiramisu to the list of dishes inside the scriptable object Dishes
            dishScript.dishesList.Add(dishScript.tiramisuIngredients);
            audioSource.Play();
            tiramisuCube.SetActive(false);
            menuScript.buy = true;
        }
    }

    public void BuyingDumplings()
    {
        if (dishScript.ShowScore() >= dumplingsPrice)
        {
            Debug.Log("Dumplings Bought");
            //Deducting the cost of tiramisu recipe from the overall score in the scriptable object Dishes
            dishScript.DeductScore(dumplingsPrice);
            // Add tiramisu to the list of dishes inside the scriptable object Dishes
            dishScript.dishesList.Add(dishScript.dumplingsIngredients);
            audioSource.Play();
            dumplingCube.SetActive(false);
            menuScript.buy = true;
        }
    }

    public void BuyingShakshuka()
    {
        if (dishScript.ShowScore() >= shakshukaPrice)
        {
            Debug.Log("Shakshuka Bought");
            //Deducting the cost of tiramisu recipe from the overall score in the scriptable object Dishes
            dishScript.DeductScore(shakshukaPrice);
            // Add tiramisu to the list of dishes inside the scriptable object Dishes
            dishScript.dishesList.Add(dishScript.shakshukaIngredients);
            audioSource.Play();
            shakshukaCube.SetActive(false);
            menuScript.buy = true;
        }
    }

    public void BuyingChurros()
    {
        if (dishScript.ShowScore() >= churrosPrice)
        {
            Debug.Log("Churros Bought");
            //Deducting the cost of tiramisu recipe from the overall score in the scriptable object Dishes
            dishScript.DeductScore(churrosPrice);
            // Add tiramisu to the list of dishes inside the scriptable object Dishes
            dishScript.dishesList.Add(dishScript.churrosIngredients);
            audioSource.Play();
            churrosCube.SetActive(false);
            menuScript.buy = true;
        }
    }







    public void CloseShop()
    {
        shop.SetActive(false);
        shopButton.SetActive(true);
        customizeButton.SetActive(true);
    }

    public void Menu()
    {
        customize.SetActive(false);
        shopButton.SetActive(true);
        customizeButton.SetActive(true);
    }
}
