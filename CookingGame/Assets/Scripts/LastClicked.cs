using UnityEngine;

public class LastClicked : MonoBehaviour
{
    public GameObject drinkSelected;
   // public GameObject drinkToMake;
    public string nameDrink;

    public string OnMouseDown()
    {
        nameDrink = drinkSelected.name;
        return nameDrink;
    }
}
