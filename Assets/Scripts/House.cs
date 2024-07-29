using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class House : MonoBehaviour
{
    protected int bathrooms;
    protected int bedrooms;
    protected int livingrooms;

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
        houseInfo = GameObject.FindGameObjectWithTag("BigHouseTextBackground");
        houseInfoText = houseInfo.GetComponent<TMP_Text>();
        houseInfo.SetActive(false);
    }
    
    public abstract void SetHouseColor();

    public void ResetColor()
    {
        //Set to white color
        houseWallRenderer.material.SetColor("_Color", new Color(1,1,1,1));
    }

    //Changes Textfield
    protected void GetHouseProperties()
    {
        houseInfoText.text = $"<b>House Properties:</b>\n\nBathrooms: {bathrooms}\nBedrooms: {bedrooms}\nLivingrooms: {livingrooms}";
    }
}
