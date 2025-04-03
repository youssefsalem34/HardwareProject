using UnityEngine;

public class CustomizeMenu : MonoBehaviour
{

    public Dishes dishScript;

    [SerializeField] private GameObject customizeMenu;

    [SerializeField] private GameObject tiramisuCubeAdd;
    [SerializeField] private GameObject tiramisuCubeRemove;
    [SerializeField] private GameObject dumplingCubeAdd;
    [SerializeField] private GameObject dumplingCubeRemove;
    [SerializeField] private GameObject churrosCubeAdd;
    [SerializeField] private GameObject churrosCubeRemove;
    [SerializeField] private GameObject shakshukaCubeAdd;
    [SerializeField] private GameObject shakshukaCubeRemove;



    [SerializeField] private WinLose winLose;




    public bool buy;

    void Start()
    {
        //  customizeMenu.SetActive(false); 


        // CHECK IF PLAYER HAS BOUGHT THE RECIPE, IF YES THEN ACTIVATE BOTH REMOVE AND ADD BUTTONS

        buy = false;

        CheckCubes();
    }


    void Update()
    {
        if(buy)
        {
            CheckCubes();
            buy = false;   
        }
    }



    void CheckCubes()
    {
        if (dishScript.dishesList.Contains(dishScript.tiramisuIngredients))
        {
            tiramisuCubeAdd.SetActive(true);
            tiramisuCubeRemove.SetActive(true);
        }
        else
        {
            tiramisuCubeAdd.SetActive(false);
            tiramisuCubeRemove.SetActive(false);
        }


        if (dishScript.dishesList.Contains(dishScript.dumplingsIngredients))
        {
            dumplingCubeAdd.SetActive(true);
            dumplingCubeRemove.SetActive(true);
        }
        else
        {
            dumplingCubeAdd.SetActive(false);
            dumplingCubeRemove.SetActive(false);
        }


        if (dishScript.dishesList.Contains(dishScript.shakshukaIngredients))
        {
            shakshukaCubeAdd.SetActive(true);
            shakshukaCubeRemove.SetActive(true);
        }
        else
        {
            shakshukaCubeAdd.SetActive(false);
            shakshukaCubeRemove.SetActive(false);
        }


        if (dishScript.dishesList.Contains(dishScript.churrosIngredients))
        {
            churrosCubeAdd.SetActive(true);
            churrosCubeRemove.SetActive(true);
        }
        else
        {
            churrosCubeAdd.SetActive(false);
            churrosCubeRemove.SetActive(false);
        }


        if (dishScript.menuList.Contains(dishScript.tiramisuIngredients) && dishScript.menuList.Contains(dishScript.dumplingsIngredients) && dishScript.menuList.Contains(dishScript.shakshukaIngredients) && dishScript.menuList.Contains(dishScript.churrosIngredients))
        {
            Debug.Log("All recipes added");
            dishScript.fruitDone = true;
        }
        else if(!dishScript.menuList.Contains(dishScript.tiramisuIngredients) || !dishScript.menuList.Contains(dishScript.dumplingsIngredients) || !dishScript.menuList.Contains(dishScript.shakshukaIngredients) || !dishScript.menuList.Contains(dishScript.churrosIngredients))
        {
            dishScript.fruitDone = false;
        }
    }

    public void AddTiramisu()
    {
        dishScript.menuList.Add(dishScript.tiramisuIngredients);
        tiramisuCubeAdd.SetActive(false);
        tiramisuCubeRemove.SetActive(true);
    }

    public void RemoveTiramisu()
    {
        dishScript.menuList.Remove(dishScript.tiramisuIngredients);
        tiramisuCubeAdd.SetActive(true);
        tiramisuCubeRemove.SetActive(false);
    }

    public void AddDumplings()
    {
        dishScript.menuList.Add(dishScript.dumplingsIngredients);
        dumplingCubeAdd.SetActive(false);
        dumplingCubeRemove.SetActive(true);
    }

    public void RemoveDumplings()
    {
        dishScript.menuList.Remove(dishScript.dumplingsIngredients);
        dumplingCubeAdd.SetActive(true);
        dumplingCubeRemove.SetActive(false);
    }

    public void AddShakshuka()
    {
        dishScript.menuList.Add(dishScript.shakshukaIngredients);
        shakshukaCubeAdd.SetActive(false);
        shakshukaCubeRemove.SetActive(true);
    }

    public void RemoveShakshuka()
    {
        dishScript.menuList.Remove(dishScript.shakshukaIngredients);
        shakshukaCubeAdd.SetActive(true);
        shakshukaCubeRemove.SetActive(false);
    }

    public void AddChurros()
    {
        dishScript.menuList.Add(dishScript.churrosIngredients);
        churrosCubeAdd.SetActive(false);
        churrosCubeRemove.SetActive(true);
    }

    public void RemoveChurros()
    {
        dishScript.menuList.Remove(dishScript.churrosIngredients);
        churrosCubeAdd.SetActive(true);
        churrosCubeRemove.SetActive(false);
    }
}
