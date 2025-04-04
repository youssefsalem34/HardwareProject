﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stream : MonoBehaviour
{
    private LineRenderer lineRenderer = null;
    private Vector3 targetPosition = Vector3.zero;

    [SerializeField] private GameObject water;
  //  [SerializeField] private float spawnInterval = 0.5f; // Water spawn interval




    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }

    private void Start()
    {
        MoveToPosition(0, transform.position);
        MoveToPosition(1, transform.position);
    }

    public void Begin()
    {
        StartCoroutine(BeginPour());
    }

    private IEnumerator BeginPour()
    {
        while (gameObject.activeSelf)
        {
            targetPosition = FindEndPoint();

            MoveToPosition(0, transform.position);
            MoveToPosition(1, targetPosition);



       //     SpawnWater(targetPosition);



         //   yield return new WaitForSeconds(spawnInterval); // Delay of 0.5s
            yield return null;
        }
        
    }

    private Vector3 FindEndPoint()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        Physics.Raycast(ray, out hit, 2.0f);
        Vector3 endPoint = hit.collider ? hit.point : ray.GetPoint(2.0f);

        return endPoint;

       // return Vector3.zero;
    }



    //private void SpawnWater(Vector3 position)
    //{
    //    Instantiate(water, position, Quaternion.identity);
    //}

    private void MoveToPosition(int index, Vector3 targetPosition)
    {
        lineRenderer.SetPosition(index, targetPosition);
    }

    void OnCollisionEnter(Collision collision)
    {
      //  if (collision.gameObject.CompareTag("Finish"))
      //  {
            Instantiate(water, collision.transform.position, Quaternion.identity);
       // }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Finish"))
        {
            Instantiate(water, collider.transform.position, Quaternion.identity);
        }
    }
}
