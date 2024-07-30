using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Inheritance - Superclass
public abstract class House : MonoBehaviour
{
    private int bathrooms;
    private int bedrooms;
    private int livingrooms;

    protected GameObject houseWall;
    protected Renderer houseWallRenderer;
    protected GameObject houseInfo;
    protected TMP_Text houseInfoText;
    
    protected House(int bathrooms, int bedrooms, int livingrooms)
    {
        this.bathrooms = bathrooms;
        this.bedrooms = bedrooms;
        this.livingrooms = livingrooms;
    }

    protected void Awake()
    {
        houseWall = transform.GetChild(7).gameObject;
        houseWallRenderer = houseWall.GetComponent<Renderer>();
    }
    
    //Polymorphism - every inherited class must implement SetHouseColor method
    public abstract void SetHouseColor();

    //Abstraciton 
    public void ResetColor()
    {
        //Set to white color
        houseWallRenderer.material.SetColor("_Color", new Color(1,1,1,1));
    }

    //Encapsulation - can't access bathroom, livingroom and bedroom variables directly
    protected void GetHouseProperties(TMP_Text infoText)
    {
        infoText.text = $"<b>House Features:</b>\n\nBathrooms: {bathrooms}\nBedrooms: {bedrooms}\nLivingrooms: {livingrooms}";
    }
}
