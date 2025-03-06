using UnityEngine;

public class CuttingBoardTagCheck : MonoBehaviour
{
    [SerializeField] private GameObject cuttingText;

    // List of valid tags for the trigger
    private readonly string[] validTags = {"Bacon","CutBacon","BaconHolder", "Cabbage","CutCabbage", "CabbageHolder",  "Parsley", "Coriander"};

    void Start()
    {
        cuttingText.SetActive(false);  // Hide text at the start
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collided with: " + col.gameObject.name + " | Tag: " + col.gameObject.tag);

        // If the ingredient tag is valid, hide the text; otherwise, show it.
        if (System.Array.Exists(validTags, tag => tag == col.gameObject.tag))
        {
            Debug.Log("Valid ingredient detected: " + col.gameObject.tag);
            cuttingText.SetActive(false);  // Hide text for valid ingredients
        }
        else
        {
            Debug.LogWarning("Invalid ingredient detected: " + col.gameObject.tag);
            cuttingText.SetActive(true);   // Show warning text for invalid ingredients
        }
    }
}
