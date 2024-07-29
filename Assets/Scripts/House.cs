using UnityEngine;
using UnityEngine.UI;

public abstract class House : MonoBehaviour
{
    protected int bathrooms;
    protected int bedrooms;
    protected int livingrooms;

    protected GameObject houseWall;
    protected Renderer houseWallRenderer;
    
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
    
    public abstract void SetHouseColor();

    public void ResetColor()
    {
        //Set to white color
        houseWallRenderer.material.SetColor("_Color", new Color(1,1,1,1));
    }
}
