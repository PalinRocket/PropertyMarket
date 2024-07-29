using UnityEngine;
using TMPro;

public class BigHouse : House
{
    
    private Color blueColor = new Color(0.07355822f,0.4353032f,0.5377358f,1);
    private bool mouseHover = false;
    

    public BigHouse() : base(3,4,2)
    {
    }
    
    public override void SetHouseColor()
    {
        //Set to blue color
        houseWallRenderer.material.SetColor("_Color", blueColor);
    }

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        if(!mouseHover)
        {
            GetHouseProperties();
            houseInfo.SetActive(true);
        }
        mouseHover = true;
    }

    void OnMouseExit()
    {
        mouseHover = false;
        houseInfo.SetActive(false);
    }
}


