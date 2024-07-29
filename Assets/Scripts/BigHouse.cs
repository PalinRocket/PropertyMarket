using UnityEngine;
using TMPro;

public class BigHouse : House
{
    
    private Color blueColor = new Color(0.07355822f,0.4353032f,0.5377358f,1);
    public BigHouse() : base(3,4,2)
    {
    }
    
    public override void SetHouseColor()
    {
        //Set to blue color
        houseWallRenderer.material.SetColor("_Color", blueColor);
    }
}


