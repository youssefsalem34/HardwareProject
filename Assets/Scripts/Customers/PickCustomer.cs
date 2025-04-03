using System.Collections.Generic;
using UnityEngine;
using System.Collections; // Required for Coroutine

public class PickCustomer : MonoBehaviour
{
    public List<GameObject> customers = new List<GameObject>();
    [SerializeField] private GameObject bannedCustomer;
    [SerializeField] private GameObject newCustomer;
    [SerializeField] private GameObject newCustomerPosition;
    [SerializeField] private IsBannedBool isbannedScript;
    [SerializeField] private GameObject cus2Position;
    [SerializeField] private GameObject cus3Position;
    [SerializeField] private GameObject cus4Position;
    [SerializeField] private GameObject customer1UI;
    [SerializeField] private GameObject customer2UI;
    [SerializeField] private GameObject customer3UI;
    [SerializeField] private Score scoreScript;

    public int customerNumber;

    [SerializeField] private DishesOLD newDishScript;

    public bool isBanned;
    public bool destroyCustomer;
    public bool spawnOtherCustomers;

    [SerializeField] private AudioSource audioSource;
   [SerializeField] private AudioSource correctBan;



    public bool canKick = true; // Cooldown flag
    [SerializeField] private float kickCooldown = 3f; // Cooldown time in seconds

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        //spawns the first customer when the games starts
        int randomIndexx = Random.Range(0, customers.Count);
        newCustomer = customers[randomIndexx];
        Instantiate(newCustomer, newCustomerPosition.transform.position, Quaternion.identity);

        spawnOtherCustomers = true;


        int randomIndex = Random.Range(0, customers.Count);
        bannedCustomer = customers[randomIndex];
        ShowBannedCustomer();
    }

    void Update()
    {
        int randomIndex = Random.Range(0, customers.Count);
        newCustomer = customers[randomIndex];




        //Spawns the other customers behind the main one
        if (spawnOtherCustomers == true)
        {
            Instantiate(newCustomer, cus2Position.transform.position, Quaternion.identity);
            int randomIndexx = Random.Range(0, customers.Count);
            newCustomer = customers[randomIndexx];
            Instantiate(newCustomer, cus3Position.transform.position, Quaternion.identity);
            int randomIndexxx = Random.Range(0, customers.Count);
            newCustomer = customers[randomIndexxx];
            Instantiate(newCustomer, cus4Position.transform.position, Quaternion.identity);
            spawnOtherCustomers = false;
        }

        CheckCustomer();
        NewDishNewCustomer();
    }
    //Makes the banned customer UI appear
    void ShowBannedCustomer()
    {
        if (bannedCustomer != null)
        {
            int index = customers.IndexOf(bannedCustomer);
            if (index == 1)
                customer1UI.SetActive(true);
            else if (index == 0)
                customer2UI.SetActive(true);
            else if (index == 2)
                customer3UI.SetActive(true);
        }
    }

    void NewDishNewCustomer()
    {
        if (newDishScript.newDish == true)
        {
            destroyCustomer = true;
            Instantiate(newCustomer, newCustomerPosition.transform.position, Quaternion.identity);
        }
    }
   

    void CheckCustomer()
    {
        int index = customers.IndexOf(bannedCustomer);

        if (customerNumber == 2 && index == 1)
        {
            isBanned = true;
        }
        else if (customerNumber == 1 && index == 0)
        {
            isBanned = true;

        }
        else if(customerNumber == 3 && index == 2)
        {
            isBanned = true;

        }
        else
        {
            isBanned = false;
        }
    }





    public void KickCustomer()
    {
        if (canKick && isBanned)
        {
            StartCoroutine(KickCustomerWithDelay());
        }
        else if(canKick && !isBanned)
        {
            StartCoroutine(KickWrongCustomerWithDelay());
        }
    }

    private IEnumerator KickCustomerWithDelay()
    {
       
        canKick = false; // Prevent spamming
     
        newDishScript.newDish = true;

        destroyCustomer = true;
        correctBan.Play();

        //Destroy previous customer here

       // Instantiate(newCustomer, newCustomerPosition.transform.position, Quaternion.identity);
        isBanned = false;


        yield return new WaitForSeconds(kickCooldown); // Wait for cooldown

        canKick = true; // Allow kicking again
        
    }

    private IEnumerator KickWrongCustomerWithDelay()
    {
        scoreScript.DecreaseScore(3);
        canKick = false; // Prevent spamming
       
        newDishScript.newDish = true;

        destroyCustomer = true;
        audioSource.Play();
        //Destroy previous customer here

        // Instantiate(newCustomer, newCustomerPosition.transform.position, Quaternion.identity);
        isBanned = false ;


        yield return new WaitForSeconds(kickCooldown); // Wait for cooldown

        canKick = true; // Allow kicking again

    }
}
