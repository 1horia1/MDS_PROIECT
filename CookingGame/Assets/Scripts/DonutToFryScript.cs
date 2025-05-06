using UnityEngine;

public class DonutToFryScript : MonoBehaviour
{
    public GameObject donutFromAbove;
    public GameObject donutOnStoveInScene; 

    void OnMouseDown()
    {
        GameObject newDonut = Instantiate(donutFromAbove, transform.position, transform.rotation);

        DragAndDrop dragScript = newDonut.GetComponent<DragAndDrop>();
        if (dragScript != null)
        {
            dragScript.donutOnTheStove = donutOnStoveInScene; 
            dragScript.StartDragging();
        }
    }
}
