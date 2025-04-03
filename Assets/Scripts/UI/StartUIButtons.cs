using UnityEngine;
using UnityEngine.SceneManagement;
public class StartUIButtons : MonoBehaviour
{
    [SerializeField] private GameObject credits;

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        credits.SetActive(true);
    }
    
   
    
}
