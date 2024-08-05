using UnityEngine;
using TMPro;

//Subclass BigHouse inherits from superclass House
public class BigHouse : House
{
    private Color blueColor = new Color(0.07355822f,0.4353032f,0.5377358f,1);
    private bool mouseHover = false;
    
    //When a bigHouse-object is initialized it uses the constructor of superclass House
    public BigHouse() : base(3,4,2)
    {
    }
    
    private void Start()
    {
        houseInfo = GameObject.FindGameObjectWithTag("BigHouseTextBackground");
        houseInfoText = houseInfo.GetComponent<TMP_Text>();
        houseInfo.transform.parent.gameObject.SetActive(false);
    }
    
    public override void SetHouseColor()
    {
        //Set to blue color
        houseWallRenderer.material.SetColor("_Color", blueColor);
    }

    void OnMouseOver()
    {
        if(!mouseHover)
        {
            GetHouseProperties(houseInfoText);
            houseInfo.transform.parent.gameObject.SetActive(true);
        }
        mouseHover = true;
    }

    void OnMouseExit()
    {
        mouseHover = false;
        houseInfo.transform.parent.gameObject.SetActive(false);
    }
}


