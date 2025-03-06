using UnityEngine;

public class InstanIngreds : MonoBehaviour
{
    private GameObject cube;
    private GameObject cyllinder;
    private GameObject bacon;
    private GameObject bellPepper;
    private GameObject biscuits;
    private GameObject cabbage;
    private GameObject carrot;
    private GameObject chicken;
    private GameObject cocoa;
    private GameObject coffee;
    private GameObject coriander;
    private GameObject dough;
    private GameObject egg;
    private GameObject garlic;
    private GameObject ginger;
    private GameObject greenOnion;
    private GameObject onion;
    private GameObject parsley;
    private GameObject pepper;
    private GameObject redWine;
    private GameObject salt;
    private GameObject soySauce;
    private GameObject sugar;
    private GameObject tomatoe;
    private GameObject water;
    private GameObject sphere;
    private GameObject spawnIngredients;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube = Resources.Load("Cube") as GameObject;
        sphere = Resources.Load("Sphere") as GameObject;
        cyllinder = Resources.Load("Cylinder") as GameObject;
        bellPepper = Resources.Load("BellPepper") as GameObject;
        bacon = Resources.Load("Bacon") as GameObject;
        biscuits = Resources.Load("Biscuits") as GameObject;
        cabbage = Resources.Load("Cabbage") as GameObject;
        carrot = Resources.Load("Carrots") as GameObject;
        chicken = Resources.Load("Chicken") as GameObject;
        cocoa = Resources.Load("Cocoa Powder") as GameObject;
        coffee = Resources.Load("Coffee") as GameObject;
        coriander = Resources.Load("Coriander") as GameObject;
        dough = Resources.Load("Dough") as GameObject;
        egg = Resources.Load("Egg") as GameObject;
        garlic = Resources.Load("Garlic") as GameObject;
        ginger = Resources.Load("Ginger") as GameObject;
        greenOnion = Resources.Load("Green Onions") as GameObject;
        onion = Resources.Load("Onion") as GameObject;
        parsley = Resources.Load("Parsley") as GameObject;
        pepper = Resources.Load("Pepper") as GameObject;
        redWine = Resources.Load("RedWine") as GameObject;
        salt = Resources.Load("Salt") as GameObject;
        soySauce = Resources.Load("Soy Sauce") as GameObject;
        sugar = Resources.Load("Sugar") as GameObject;
        tomatoe = Resources.Load("Tomatoe") as GameObject;
        water = Resources.Load("Bottle") as GameObject;
        spawnIngredients = GameObject.FindWithTag("Respawn");
    }



    public void SpawnCube()
    {
        Instantiate(cube, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnSphere()
    {
        Instantiate(sphere, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCyllinder()
    {
        Instantiate(cyllinder, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnBacon()
    {
        Instantiate(bacon, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnBellPepper()
    {
        Instantiate(bellPepper, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnBiscuits()
    {
        Instantiate(biscuits, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCabbage()
    {
        Instantiate(cabbage, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCarrots()
    {
        Instantiate(carrot, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnChicken()
    {
        Instantiate(chicken, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCocoa()
    {
        Instantiate(cocoa, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCoffee()
    {
        Instantiate(coffee, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnCoriander()
    {
        Instantiate(coriander, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnDough()
    {
        Instantiate(dough, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnEgg()
    {
        Instantiate(egg, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnGarlic()
    {
        Instantiate(garlic, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnGinger()
    {
        Instantiate(ginger, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnGreenOnion()
    {
        Instantiate(greenOnion, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnOnion()
    {
        Instantiate(onion, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnParsley()
    {
        Instantiate(parsley, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnPepper()
    {
        Instantiate(pepper, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnRedwine()
    {
        Instantiate(redWine, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnSalt()
    {
        Instantiate(salt, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnSoySauce()
    {
        Instantiate(soySauce, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnSugar()
    {
        Instantiate(sugar, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnTomatoe()
    {
        Instantiate(tomatoe, spawnIngredients.transform.position, Quaternion.identity);
    }
    public void SpawnWater()
    {
        Instantiate(water, spawnIngredients.transform.position, Quaternion.identity);
    }
   
}
