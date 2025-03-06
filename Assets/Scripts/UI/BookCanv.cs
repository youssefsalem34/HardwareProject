using UnityEngine;

public class BookCanv : MonoBehaviour
{
   [SerializeField] private GameObject prevButton;
   [SerializeField] private GameObject nextButton;
   [SerializeField] private GameObject page1;
   [SerializeField] private GameObject page2;
   [SerializeField] private GameObject page3;
   [SerializeField] private GameObject page4;


    private void Start()
    {
       // page2.SetActive(false);
      //  page3.SetActive(false);
      //  page4.SetActive(false);
    }
    public void  NextPage()
    {
        if(page1.activeSelf)
        {
            page2.SetActive(true);
            page1.SetActive(false) ;
        }
        else if (page2.activeSelf)
        {
            page3.SetActive(true);
            page2.SetActive(false);
        }
        else if (page3.activeSelf)
        {
            page4.SetActive(true);
            page3.SetActive(false);
        }
        else if (page4.activeSelf)
        {
          
        }
    }
    public void previousPage()
    {
        if(page1.activeSelf)
        {

        }
        else if(page2.activeSelf)
        {
            page1.SetActive(true);
            page2.SetActive(false);
        }
        else if (page3.activeSelf)
        {
            page2.SetActive(true);
            page3.SetActive(false);
        }
        else if (page4.activeSelf)
        {
            page3.SetActive(true);
            page4.SetActive(false);
        }
    }

}
