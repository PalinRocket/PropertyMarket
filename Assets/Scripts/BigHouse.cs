using UnityEngine;
using TMPro;

public class BigHouse : House
{
    [SerializeField] TMP_InputField houseNameInput;
    public BigHouse() : base(3,4,2)
    {
    }

    protected override void SetName()
    {
        this.houseName = houseNameInput.text;
    }

    public void GetBathrooms()
    {
        Debug.Log(this.bathrooms);
    }
}
