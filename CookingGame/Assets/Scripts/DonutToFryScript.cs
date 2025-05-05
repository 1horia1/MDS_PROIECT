using UnityEngine;
using UnityEngine.UI;

public class DonutToFryScript : MonoBehaviour
{
    public GameObject donutFromAbove;

    void OnMouseDown()
    {
        GameObject newDonut = Instantiate(donutFromAbove, transform.position, transform.rotation);

        DragAndDrop dragScript = newDonut.GetComponent<DragAndDrop>();
        if (dragScript != null)
        {
            dragScript.StartDragging();
        }
    }
}
