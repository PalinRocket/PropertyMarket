using UnityEngine;

public abstract class House : MonoBehaviour
{
    protected string houseName;
    protected int bathrooms;
    protected int bedrooms;
    protected int livingrooms;
    
    protected House(int bathrooms, int bedrooms, int livingrooms)
    {
        this.bathrooms = bathrooms;
        this.bedrooms = bedrooms;
        this.livingrooms = livingrooms;
    }
    
    public void GetName()
    {
        Debug.Log(houseName);
    }

    protected abstract void SetName();
}
