using UnityEngine;

public class TurnAround : MonoBehaviour
{
    void Update()
    {
        // Make the GameObject look at the world origin (0, 0, 0)
        transform.LookAt(Vector3.zero);
    }
}
