using UnityEngine;

public class IsBannedBool : MonoBehaviour
{
    [SerializeField] private PickCustomer customerScript;
    [SerializeField] public GameObject currentCus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (customerScript.destroyCustomer == true )
        {
            Destroy(currentCus);
            // currentCus.SetActive(false);
            customerScript.destroyCustomer = false;
        }
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Boy1"))
        {
            currentCus = col.gameObject;
            customerScript.customerNumber = 1;
        }
        else if (col.gameObject.CompareTag("Girl1"))
        {
            currentCus = col.gameObject;

            customerScript.customerNumber = 2;
        }
        else if (col.gameObject.CompareTag("Girl2"))
        {
            currentCus = col.gameObject;

            customerScript.customerNumber = 3;
        }
    }

  
}
