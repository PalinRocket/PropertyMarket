using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Subclass SmallHouse inherits from superclass House
public class SmallHouse : House
{
    private Color purpleColor = new Color(0.311256f, 0.06f, 0.3f, 1);
    private bool mouseHover = false;

    public SmallHouse() : base(1,2,1)
    {
    }
   
    private void Start()
    {
        houseInfo = GameObject.FindGameObjectWithTag("SmallHouseTextBackground");
        houseInfoText = houseInfo.GetComponent<TMP_Text>();
        houseInfo.transform.parent.gameObject.SetActive(false);
    }
    

    public override void SetHouseColor()
    {
        //Set purple color
        houseWallRenderer.material.SetColor("_Color", purpleColor);
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
