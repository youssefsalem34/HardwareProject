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

    void Start()
    {
      //  customizeMenu.SetActive(false); 


        // CHECK IF PLAYER HAS BOUGHT THE RECIPE, IF YES THEN ACTIVATE BOTH REMOVE AND ADD BUTTONS



        //if (dishScript.menuList.Contains(dishScript.tiramisuIngredients))
        //{
        //    tiramisuCube.SetActive(false);
        //}
        //else
        //{

        //}


        //if (dishScript.menuList.Contains(dishScript.dumplingsIngredients))
        //{
        //    dumplingCube.SetActive(false);
        //}
        //else
        //{

        //}


        //if (dishScript.menuList.Contains(dishScript.shakshukaIngredients))
        //{
        //    shakshukaCube.SetActive(false);
        //}
        //else
        //{

        //}


        //if (dishScript.menuList.Contains(dishScript.churrosIngredients))
        //{
        //    churrosCube.SetActive(false);
        //}
        //else
        //{

        //}
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
