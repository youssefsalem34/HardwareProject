using UnityEngine;
using System.Collections;

public class CuttingOnion : MonoBehaviour
{
    [SerializeField] private GameObject baconPrefab; // Prefab to instantiate
    [SerializeField] private GameObject bacon; // Placeholder bacon on the board
    [SerializeField] private Animator animator; // Reference to the Animator component
    [SerializeField] private bool isBaconOnBoard = false; // Track if bacon is on the board
    private bool isCutting = false; // Prevent redundant cutting processes
    private AudioSource audioSource;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        //  bacon.SetActive(false); // Hide the placeholder bacon initially

        if (baconPrefab == null)
        {
            baconPrefab = Resources.Load("CutOnion") as GameObject;
        }

        if (animator == null)
        {
            Debug.LogError("Animator is not assigned!");
        }
    }

    void Update()
    {
        if (isBaconOnBoard && !isCutting)
        {
            StartCutting();
        }
    }

    void StartCutting()
    {
        if (isCutting) return; // Prevent multiple cutting processes
        isCutting = true;

        // Play the cutting animation
        if (animator != null)
        {
            animator.SetBool("isCutting", true);
            audioSource.Play();
        }

        StartCoroutine(CutDish());
    }

    void StopCutting()
    {
        if (animator != null)
        {
            animator.SetBool("isCutting", false);
        }
        isCutting = false; // Allow cutting to restart
    }

    IEnumerator CutDish()
    {
        yield return new WaitForSeconds(2f);

        StopCutting();
        bacon.SetActive(false); // Hide the original bacon

        // Spawn the cut bacon
        Instantiate(baconPrefab, bacon.transform.position, Quaternion.identity);

        isBaconOnBoard = false; // Reset the bacon flag
        Debug.Log("Bacon Found and Cut!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Onion") && !isBaconOnBoard)
        {
            Destroy(other.gameObject); // Destroy the original bacon object
            bacon.SetActive(true); // Show the placeholder bacon
            isBaconOnBoard = true; // Mark bacon as being on the board
        }
    }
}