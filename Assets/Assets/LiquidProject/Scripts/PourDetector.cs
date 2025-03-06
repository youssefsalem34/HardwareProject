using System.Collections;
using UnityEngine;

public class PourDetector : MonoBehaviour
{
    public int pourThreshold = 45;
    public Transform origin = null;
    public GameObject streamPrefab = null;
    public GameObject cube;

    private bool isPouring = false;
    private Stream currentStream = null;


    [SerializeField] private GameObject water;
    [SerializeField] private float spawnInterval = 0.5f; // Water spawn interval


    private void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;


        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;

            if (isPouring)
            {
                StartPour();
                cube.SetActive(true);
                StartCoroutine(SpawnWaterRoutine());
            }
            else
            {
                EndPour();
                cube.SetActive(false);
            }
        }

        
    }


    private void StartPour()
    {
        currentStream = CreateStream();
        currentStream.Begin();
        
    }

    private void EndPour()
    {


    }

    private IEnumerator SpawnWaterRoutine()
    {
        while (cube.activeSelf) // Keep spawning as long as the cube is active
        {
            SpawnWater();
            yield return new WaitForSeconds(spawnInterval); // Wait before spawning again
        }
    }
    private void SpawnWater()
    {
        Instantiate(water, cube.transform.position, Quaternion.identity);
    }


    private float CalculatePourAngle()
    {
        return transform.forward.y * Mathf.Rad2Deg;
    }

    private Stream CreateStream()
    {
        GameObject streamObject = Instantiate(streamPrefab, origin.position, Quaternion.identity, transform);
        return streamObject.GetComponent<Stream>();
    }
}