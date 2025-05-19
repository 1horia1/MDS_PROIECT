using UnityEngine;

public class DonutToFryScript : MonoBehaviour
{
    public GameObject donutFromAbove;
    public GameObject donutOnStoveInScene_left;
    public GameObject donutOnStoveInScene_right;
    public GameObject instructionsPannelInScene;

    void OnMouseDown()
    {
        GameObject newDonut = Instantiate(donutFromAbove, transform.position, transform.rotation);

        DragAndDrop dragScript = newDonut.GetComponent<DragAndDrop>();
        if (dragScript != null)
        {
            dragScript.donutOnTheStove_left = donutOnStoveInScene_left;
            dragScript.donutOnTheStove_right = donutOnStoveInScene_right;
            dragScript.script = instructionsPannelInScene.GetComponent<PannelScript>();
        
            dragScript.StartDragging();
        }
    }

}
