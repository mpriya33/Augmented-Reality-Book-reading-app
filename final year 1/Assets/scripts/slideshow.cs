using UnityEngine;
using UnityEngine.UI;

public class slideshow : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject prevBtn;
    public string[] mImg;
    private int counter = 0;
    void Start()
    {
        mImg = new string[] { "blueocean1", "blueocean2", "blueocean3" };
    }
    
    public void next()
    {
        counter++;
        checkBtns();
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(mImg[counter]);
    }
    public void prev()
    {
        counter--;
        checkBtns();
        gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(mImg[counter]);
        
    }
    private void checkBtns()
    {
        if (counter < 1)
        {
            prevBtn.SetActive(false);
        }
        else
        {
            prevBtn.SetActive(true);
        }
        if (counter > mImg.Length - 2)
        {
            nextBtn.SetActive(false);
        }
        else
        {
            nextBtn.SetActive(true);
        }
    }
}
